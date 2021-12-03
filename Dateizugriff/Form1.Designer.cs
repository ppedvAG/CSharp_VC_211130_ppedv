namespace Dateien
{
    partial class Form1
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
            this.Tbx_Input = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_SaveP = new System.Windows.Forms.Button();
            this.Btn_LoadP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tbx_Input
            // 
            this.Tbx_Input.AcceptsReturn = true;
            this.Tbx_Input.Location = new System.Drawing.Point(33, 25);
            this.Tbx_Input.Multiline = true;
            this.Tbx_Input.Name = "Tbx_Input";
            this.Tbx_Input.Size = new System.Drawing.Size(179, 187);
            this.Tbx_Input.TabIndex = 0;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(218, 25);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(94, 29);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.Text = "Speichern";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Load
            // 
            this.Btn_Load.Location = new System.Drawing.Point(218, 60);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(94, 29);
            this.Btn_Load.TabIndex = 2;
            this.Btn_Load.Text = "Laden";
            this.Btn_Load.UseVisualStyleBackColor = true;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // Btn_SaveP
            // 
            this.Btn_SaveP.Location = new System.Drawing.Point(318, 26);
            this.Btn_SaveP.Name = "Btn_SaveP";
            this.Btn_SaveP.Size = new System.Drawing.Size(158, 29);
            this.Btn_SaveP.TabIndex = 3;
            this.Btn_SaveP.Text = "Speichere Person";
            this.Btn_SaveP.UseVisualStyleBackColor = true;
            this.Btn_SaveP.Click += new System.EventHandler(this.Btn_SaveP_Click);
            // 
            // Btn_LoadP
            // 
            this.Btn_LoadP.Location = new System.Drawing.Point(318, 60);
            this.Btn_LoadP.Name = "Btn_LoadP";
            this.Btn_LoadP.Size = new System.Drawing.Size(158, 29);
            this.Btn_LoadP.TabIndex = 4;
            this.Btn_LoadP.Text = "Lade Person";
            this.Btn_LoadP.UseVisualStyleBackColor = true;
            this.Btn_LoadP.Click += new System.EventHandler(this.Btn_LoadP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 277);
            this.Controls.Add(this.Btn_LoadP);
            this.Controls.Add(this.Btn_SaveP);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Tbx_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Tbx_Input;
        private Button Btn_Save;
        private Button Btn_Load;
        private Button Btn_SaveP;
        private Button Btn_LoadP;
    }
}