
namespace FahrzeugGUI
{
    partial class Wnd_FahrzeugVerwaltung
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
            this.Lbx_Fahrzeuge = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Löschen = new System.Windows.Forms.Button();
            this.Btn_Neu = new System.Windows.Forms.Button();
            this.Lbl_Info = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MeI_Beenden = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_LadeFz = new System.Windows.Forms.Button();
            this.Btn_SpeichereFz = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbx_Fahrzeuge
            // 
            this.Lbx_Fahrzeuge.FormattingEnabled = true;
            this.Lbx_Fahrzeuge.ItemHeight = 20;
            this.Lbx_Fahrzeuge.Location = new System.Drawing.Point(12, 81);
            this.Lbx_Fahrzeuge.Name = "Lbx_Fahrzeuge";
            this.Lbx_Fahrzeuge.Size = new System.Drawing.Size(261, 184);
            this.Lbx_Fahrzeuge.TabIndex = 1;
            this.Lbx_Fahrzeuge.SelectedIndexChanged += new System.EventHandler(this.Lbx_Fahrzeuge_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vorhandene Fahrzeuge:";
            // 
            // Btn_Löschen
            // 
            this.Btn_Löschen.Location = new System.Drawing.Point(488, 81);
            this.Btn_Löschen.Name = "Btn_Löschen";
            this.Btn_Löschen.Size = new System.Drawing.Size(157, 38);
            this.Btn_Löschen.TabIndex = 6;
            this.Btn_Löschen.Text = "Lösche Fahrzeug";
            this.Btn_Löschen.UseVisualStyleBackColor = true;
            this.Btn_Löschen.Click += new System.EventHandler(this.Btn_Löschen_Click);
            // 
            // Btn_Neu
            // 
            this.Btn_Neu.Location = new System.Drawing.Point(325, 81);
            this.Btn_Neu.Name = "Btn_Neu";
            this.Btn_Neu.Size = new System.Drawing.Size(157, 38);
            this.Btn_Neu.TabIndex = 5;
            this.Btn_Neu.Text = "Neues Fahrzeug";
            this.Btn_Neu.UseVisualStyleBackColor = true;
            this.Btn_Neu.Click += new System.EventHandler(this.Btn_Neu_Click);
            // 
            // Lbl_Info
            // 
            this.Lbl_Info.AutoSize = true;
            this.Lbl_Info.Location = new System.Drawing.Point(12, 282);
            this.Lbl_Info.Name = "Lbl_Info";
            this.Lbl_Info.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Info.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MeI_Beenden});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // MeI_Beenden
            // 
            this.MeI_Beenden.Name = "MeI_Beenden";
            this.MeI_Beenden.Size = new System.Drawing.Size(150, 26);
            this.MeI_Beenden.Text = "Beenden";
            this.MeI_Beenden.Click += new System.EventHandler(this.MeI_Beenden_Click);
            // 
            // Btn_LadeFz
            // 
            this.Btn_LadeFz.Location = new System.Drawing.Point(325, 125);
            this.Btn_LadeFz.Name = "Btn_LadeFz";
            this.Btn_LadeFz.Size = new System.Drawing.Size(157, 38);
            this.Btn_LadeFz.TabIndex = 9;
            this.Btn_LadeFz.Text = "Lade Fahrzeuge";
            this.Btn_LadeFz.UseVisualStyleBackColor = true;
            this.Btn_LadeFz.Click += new System.EventHandler(this.Btn_LadeFz_Click);
            // 
            // Btn_SpeichereFz
            // 
            this.Btn_SpeichereFz.Location = new System.Drawing.Point(488, 125);
            this.Btn_SpeichereFz.Name = "Btn_SpeichereFz";
            this.Btn_SpeichereFz.Size = new System.Drawing.Size(157, 38);
            this.Btn_SpeichereFz.TabIndex = 10;
            this.Btn_SpeichereFz.Text = "Speichere Fahrzeuge";
            this.Btn_SpeichereFz.UseVisualStyleBackColor = true;
            this.Btn_SpeichereFz.Click += new System.EventHandler(this.Btn_SpeicherFz_Click);
            // 
            // Wnd_FahrzeugVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_SpeichereFz);
            this.Controls.Add(this.Btn_LadeFz);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Lbl_Info);
            this.Controls.Add(this.Btn_Löschen);
            this.Controls.Add(this.Btn_Neu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbx_Fahrzeuge);
            this.Name = "Wnd_FahrzeugVerwaltung";
            this.Text = "Fahrzeug-Verwaltung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lbx_Fahrzeuge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Löschen;
        private System.Windows.Forms.Button Btn_Neu;
        private System.Windows.Forms.Label Lbl_Info;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MeI_Beenden;
        private System.Windows.Forms.Button Btn_LadeFz;
        private System.Windows.Forms.Button Btn_SpeichereFz;
    }
}

