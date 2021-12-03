namespace WinFormsBsp
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnKlickMich = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.CbxHaken = new System.Windows.Forms.CheckBox();
            this.CbbAuswahl = new System.Windows.Forms.ComboBox();
            this.LbxAuswahl = new System.Windows.Forms.ListBox();
            this.TbxInput = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesFensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnKlickMich
            // 
            this.BtnKlickMich.Location = new System.Drawing.Point(56, 72);
            this.BtnKlickMich.Name = "BtnKlickMich";
            this.BtnKlickMich.Size = new System.Drawing.Size(112, 78);
            this.BtnKlickMich.TabIndex = 0;
            this.BtnKlickMich.Text = "Klick mich";
            this.BtnKlickMich.UseVisualStyleBackColor = true;
            this.BtnKlickMich.Click += new System.EventHandler(this.BtnKlickMich_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(53, 27);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(120, 20);
            this.LblOutput.TabIndex = 1;
            this.LblOutput.Text = "Ich bin ein String";
            // 
            // CbxHaken
            // 
            this.CbxHaken.AutoSize = true;
            this.CbxHaken.Checked = true;
            this.CbxHaken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbxHaken.Location = new System.Drawing.Point(109, 271);
            this.CbxHaken.Name = "CbxHaken";
            this.CbxHaken.Size = new System.Drawing.Size(114, 24);
            this.CbxHaken.TabIndex = 2;
            this.CbxHaken.Text = "Hak mich ab";
            this.CbxHaken.UseVisualStyleBackColor = true;
            // 
            // CbbAuswahl
            // 
            this.CbbAuswahl.FormattingEnabled = true;
            this.CbbAuswahl.Location = new System.Drawing.Point(318, 51);
            this.CbbAuswahl.Name = "CbbAuswahl";
            this.CbbAuswahl.Size = new System.Drawing.Size(151, 28);
            this.CbbAuswahl.TabIndex = 3;
            // 
            // LbxAuswahl
            // 
            this.LbxAuswahl.FormattingEnabled = true;
            this.LbxAuswahl.ItemHeight = 20;
            this.LbxAuswahl.Items.AddRange(new object[] {
            "Item1",
            "Eintrag2",
            "Auswahl3"});
            this.LbxAuswahl.Location = new System.Drawing.Point(318, 123);
            this.LbxAuswahl.Name = "LbxAuswahl";
            this.LbxAuswahl.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbxAuswahl.Size = new System.Drawing.Size(148, 104);
            this.LbxAuswahl.TabIndex = 4;
            // 
            // TbxInput
            // 
            this.TbxInput.AcceptsReturn = true;
            this.TbxInput.AcceptsTab = true;
            this.TbxInput.Location = new System.Drawing.Point(530, 120);
            this.TbxInput.Multiline = true;
            this.TbxInput.Name = "TbxInput";
            this.TbxInput.Size = new System.Drawing.Size(125, 113);
            this.TbxInput.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(348, 290);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(348, 320);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 36);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 24);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(555, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 116);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(27, 66);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(117, 24);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesFensterToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuesFensterToolStripMenuItem
            // 
            this.neuesFensterToolStripMenuItem.Name = "neuesFensterToolStripMenuItem";
            this.neuesFensterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.neuesFensterToolStripMenuItem.Text = "Neues Fenster";
            this.neuesFensterToolStripMenuItem.Click += new System.EventHandler(this.neuesFensterToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TbxInput);
            this.Controls.Add(this.LbxAuswahl);
            this.Controls.Add(this.CbbAuswahl);
            this.Controls.Add(this.CbxHaken);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.BtnKlickMich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Mein Fenster";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnKlickMich;
        private Label LblOutput;
        private CheckBox CbxHaken;
        private ComboBox CbbAuswahl;
        private ListBox LbxAuswahl;
        private TextBox TbxInput;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem neuesFensterToolStripMenuItem;
        private ToolStripMenuItem beendenToolStripMenuItem;
    }
}