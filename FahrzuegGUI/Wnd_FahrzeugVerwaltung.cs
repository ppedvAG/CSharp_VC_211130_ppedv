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

        //Event-Handler für das Click-Event des Menüeintrags 'Beenden'
        private void MeI_Beenden_Click(object sender, EventArgs e)
        {
            //Nachfrage per MessageBox
            string dialogText = "Möchtest du wirklich beenden?\nNicht gespeicherte Änderungen werden verworfen.";
            DialogResult result = MessageBox.Show(dialogText, "Programm schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Testen des in MessageBox geklickten Buttons
            if (result == DialogResult.Yes)
                //Schließen des Fensters
                this.Close();
        }

        //Events-Handler des 'Neu'-Buttons
        private void Btn_Neu_Click(object sender, EventArgs e)
        {
            //Erstellen eines neuen Fahrzeuges und Einfügen in die Liste
            this.Fahrzeugliste.Add(Fahrzeug.GeneriereFahrzeug());
            //Aktualisierung der ListBox
            this.UpdateGui();
        }

        //Event-Handler des 'Löschen'-Buttons
        private void Btn_Löschen_Click(object sender, EventArgs e)
        {
            //Prüfung, ob ein Eintrag ausgewählt ist
            if (Lbx_Fahrzeuge.SelectedItem != null)
                //Löschen des in der ListBox markierten Items aus der Personenliste
                LöscheFz(Lbx_Fahrzeuge.SelectedItem as Fahrzeug);

            //Aktualisierung der ListBox
            UpdateGui();
        }

        //EventHandler der ListBox (bei Auswahl-Veränderung)
        private void Lbx_Fahrzeuge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Prüfun, ob eine Auswahl in ListBox besteht
            if (Lbx_Fahrzeuge.SelectedItem != null)
                //Anzeige der Info()-Methode in Label
                Lbl_Info.Text = (Lbx_Fahrzeuge.SelectedItem as Fahrzeug).Info();
        }
        #endregion

        #region zusätzliche Methoden

        //Methode zum Löschen von Fahrzeugen
        private void LöscheFz(Fahrzeug fz)
        {
            Fahrzeugliste.Remove(fz);
        }

        //Methode zur Synchronisation von ListBox.Items und Fahrzeugliste
        private void UpdateGui()
        {
            //Löschend des ListBox-Inhalts
            this.Lbx_Fahrzeuge.Items.Clear();

            //Neubefüllung der ListBox anhand der Liste
            foreach (var item in this.Fahrzeugliste)
            {
                this.Lbx_Fahrzeuge.Items.Add(item);
            }
        }
        #endregion
    }
}
