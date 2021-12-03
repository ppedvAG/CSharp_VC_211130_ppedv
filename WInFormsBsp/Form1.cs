namespace WinFormsBsp
{
    //PARTIAL besagt, dass diese Klasse in mehrere Teile (Dateien) aufgeteilt ist
    public partial class MainWindow : Form
    {
        //Bsp-Enum
        enum BspEnum { Test1, Test2 }

        //Konstruktor für das Form (Fenster)
        public MainWindow()
        {
            //Diese Methode initialisiert alle im Designer definierten Objekte. Sie sollte die erste Methode im Konstruktor sein
            InitializeComponent();

            //Neuzuweisung einer Property eines Buttons
            BtnKlickMich.Text = "OKAY";

            //Zuweisung eines weiteren EventHandlers zu einem Event
            BtnKlickMich.Click += Btn_Ok_Click_02;

            for (int i = 0; i < Enum.GetValues(typeof(BspEnum)).Length; i++)
            {
                //Befüllung der ComboBox mit Enum-Elementen
                CbbAuswahl.Items.Add((BspEnum)i);
            }
        }

        //EventHandler-Methoden

        //EventHandler, welche auf einen Klick auf den Button 'KlickMich' reagiert
        private void BtnKlickMich_Click(object sender, EventArgs e)
        {
           //Neuzuweisung einer Eigenschaft des Forms
            this.BackColor = Color.Orange;

            //Prüfung, ob die Checkbox abgehakt wurde
            if (CbxHaken.Checked)
                //Neuzuweisung einer Eigenschaft des Labels
                LblOutput.Text = "Abgehakt";

            //Prüfung, ob in der ComboBox ein Element angewählt wurde
            if (CbbAuswahl.SelectedItem != null)
                //Übertrag des Elements in das Label
                LblOutput.Text = CbbAuswahl.SelectedItem.ToString();

            //Hinzufügen des TextBox-Inhalts als neues Element der ListBox
            LbxAuswahl.Items.Add(TbxInput.Text);

        }

        private void Btn_Ok_Click_02(object sender, EventArgs e)
        {
            //Verschieben des Elements in der sender-Variablen um 100 Pixel nach rechts
            (sender as Button).Left += 100;
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            MainWindow neuesFenster = new MainWindow();
            //Manipulation der Eigenschaften des neuen Fensters
            neuesFenster.Text = "2. Fenster";
            neuesFenster.BtnKlickMich.Text = "MOIN MOIN";
            //Öffen des Forms als Dialogfenster (muss exklusiv bearbeitet werden)
            neuesFenster.ShowDialog();
            //Öffnen des Forms als gleichberechtigtes Fenster
            neuesFenster.Show();

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox
            DialogResult result = MessageBox.Show("Möchtest du das Fenster wirklich schließen?", "Programm beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Prüfung des geklickten Buttons
            if (result == DialogResult.Yes)
                //Schließend des Fensters
                this.Close();

            //Schließend der Applikation
            //Application.Exit();
        }
    }
}