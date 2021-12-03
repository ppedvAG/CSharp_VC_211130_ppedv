using Fahrzeugpark;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FahrzeugGUI
{
    public partial class Wnd_FahrzeugVerwaltung : Form
    {
        //Liste zum Speichern der erstellten Fahrzeuge
        public List<Fahrzeug> Fahrzeugliste { get; set; }

        //Konstruktor zur Initalisierung des Fensters
        public Wnd_FahrzeugVerwaltung()
        {
            //Erstellung der im Designer definierten Elemente
            InitializeComponent();
            //Initialisierung der Liste
            this.Fahrzeugliste = new List<Fahrzeug>();
        }

        #region EventHandler-Methoden

        //Event-Handler f�r das Click-Event des Men�eintrags 'Beenden'
        private void MeI_Beenden_Click(object sender, EventArgs e)
        {
            //Nachfrage per MessageBox
            string dialogText = "M�chtest du wirklich beenden?\nNicht gespeicherte �nderungen werden verworfen.";
            DialogResult result = MessageBox.Show(dialogText, "Programm schlie�en", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Testen des in MessageBox geklickten Buttons
            if (result == DialogResult.Yes)
                //Schlie�en des Fensters
                this.Close();
        }

        //Events-Handler des 'Neu'-Buttons
        private void Btn_Neu_Click(object sender, EventArgs e)
        {
            //Erstellen eines neuen Fahrzeuges und Einf�gen in die Liste
            this.Fahrzeugliste.Add(Fahrzeug.GeneriereFahrzeug());
            //Aktualisierung der ListBox
            this.UpdateGui();
        }

        //Event-Handler des 'L�schen'-Buttons
        private void Btn_L�schen_Click(object sender, EventArgs e)
        {
            //Pr�fung, ob ein Eintrag ausgew�hlt ist
            if (Lbx_Fahrzeuge.SelectedItem != null)
                //L�schen des in der ListBox markierten Items aus der Personenliste
                L�scheFz(Lbx_Fahrzeuge.SelectedItem as Fahrzeug);

            //Aktualisierung der ListBox
            UpdateGui();
        }

        //EventHandler der ListBox (bei Auswahl-Ver�nderung)
        private void Lbx_Fahrzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pr�fung, ob eine Auswahl in ListBox besteht
            if ((sender as ListBox).SelectedItem != null)
                //Anzeige der Info()-Methode in Label
                Lbl_Info.Text = (Lbx_Fahrzeuge.SelectedItem as Fahrzeug).Info();
        }
        #endregion

        #region zus�tzliche Methoden

        //Methode zum L�schen von Fahrzeugen
        private void L�scheFz(Fahrzeug fz)
        {
            //Nachfrage per MessageBox
            string dialogText = "Soll das ausgew�hlte Fahrzeug wirklich gel�scht werden?";
            DialogResult result = MessageBox.Show(dialogText, "Fahrzeug l�schen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Testen des in MessageBox geklickten Buttons
            if (result == DialogResult.Yes)
                Fahrzeugliste.Remove(fz);
        }

        //Methode zur Synchronisation von ListBox.Items und Fahrzeugliste
        private void UpdateGui()
        {
            //L�schend des ListBox-Inhalts
            this.Lbx_Fahrzeuge.Items.Clear();

            //Neubef�llung der ListBox anhand der Liste
            foreach (var item in this.Fahrzeugliste)
            {
                this.Lbx_Fahrzeuge.Items.Add(item);
            }
        }
        #endregion

        #region Lab 15: Speichern und Laden

        private void Btn_LadeFz_Click(object sender, EventArgs e)
        {
            Fahrzeugliste = LadeFz();

            UpdateGui();
        }

        private void Btn_SpeicherFz_Click(object sender, EventArgs e)
        {
            SpeicherFz(this.Fahrzeugliste);
        }

        private List<Fahrzeug> LadeFz()
        {
            List<Fahrzeug> fzList = new List<Fahrzeug>();

            //Erstellen eines JsonSerialiserSetting-Objekt zur Spezifizierung der Serialisierung
            JsonSerializerSettings settings = new JsonSerializerSettings();
            //TypeNameHandling markiert die Json-Zeilen mit dem entsprechenden Objekt-Typ (z.B. PKW, Flugzeug, Schiff)
            settings.TypeNameHandling = TypeNameHandling.Objects;

            //Aubruf des Dateipfads
            string pfad = GetPfadViaDialog();

            //Pr�fung, ob Dateipfad vorhanden ist
            if (!String.IsNullOrEmpty(pfad))
            {
                try
                {
                    //Etablierung eines StreamReaders per using-Statement
                    using (StreamReader reader = new StreamReader(pfad))
                    {
                        while (!reader.EndOfStream)
                        {
                            //Lesen einer Textzeile aus der Datei
                            string fzAlsString = reader.ReadLine();
                            //Umwandlung der Textzeile in ein Fahrzeug (Beachte die �bergabe des Settings-Objekts)
                            Fahrzeug fz = JsonConvert.DeserializeObject<Fahrzeug>(fzAlsString, settings);
                            //Hinzuf�gen des Fahrzeugs zur Liste
                            fzList.Add(fz);
                        }
                        //Erfolgsmeldung
                        MessageBox.Show("Laden erfolgreich");
                        //R�ckgabe der geladenen Liste
                        return fzList;
                    }
                }
                catch (Exception ex)
                {
                    //Misserfolgsmeldung
                    MessageBox.Show("Laden fehlgeschlagen. " + ex.Message);
                }
            }
            //R�ckgabe der 'alten' Liste, im Fehlerfall oder wenn kein Pfad ausgew�hlt wurde
            return this.Fahrzeugliste;
        }

        private void SpeicherFz(List<Fahrzeug> fahrzeugliste)
        {
            //Erstellen der Json-Settings
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            //Erfragen des Dateipfads
            string pfad = GetPfadViaDialog(true);

            //Pr�fung, ob Pfad vorhanden ist
            if (!String.IsNullOrEmpty(pfad))
            {
                try
                {
                    //Etablierung eines StreamWriters per using-Anweisung
                    using (StreamWriter writer = new StreamWriter(pfad))
                    {
                        //Schleife �ber die Fahrzeugliste
                        for (int i = 0; i < fahrzeugliste.Count; i++)
                        {
                            //Serialisierung der Fahrzeuge
                            string fzAlsString = JsonConvert.SerializeObject(fahrzeugliste[i], settings);
                            //Speichern des Strings
                            writer.WriteLine(fzAlsString);
                        }

                        //Erfolgsmeldung
                        MessageBox.Show("Speichern erfolgreich");
                    }
                }
                catch (Exception ex)
                {
                    //Misserfolgsmeldung
                    MessageBox.Show("Speichern fehlgeschlagen. " + ex.Message);
                }
            }
        }

        private string GetPfadViaDialog(bool speichern = false)
        {
            //vorgeschlagener Standartdateiname
            string fileName = "Fahrzeuge.txt";
            //Bsp-�bergabe des Windows-Arbeitsplatzes als GUID
            string initialDirectory = "::{20d04fe0-3aea-1069-a2d8-08002b30309d}";
            //M�gliche Dateiformate
            string filter = "Textdatei|*.txt|Fahrzeugdatei|*.fz|Alle Dateien|*.*";

            //Deklaration einer allgemeinen FileDialog-Variablen
            FileDialog dialog;

            //Initialisierung gem�� Situation
            if (speichern)
                dialog = new SaveFileDialog();
            else
                dialog = new OpenFileDialog();

            //�bertrag der Propertiy-Werte
            dialog.FileName = fileName;
            dialog.InitialDirectory = initialDirectory;
            dialog.Filter = filter;

            //Ausf�hrung des Dialogs und Pr�fung, ob auf 'Ok' geklickt wurde
            if (dialog.ShowDialog() == DialogResult.OK)
                //'Ok'-Klick gibt gew�hlten Dateinamen zur�ck
                return dialog.FileName;
            else
                //'Abbruch'-Klick gibt leeren String zur�ck
                return "";
        }

        #endregion
    }
}
