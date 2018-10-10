namespace EnigmaMachine
{
    partial class RotorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSettings = new System.Windows.Forms.Label();
            this.gbDefaultRotors = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSettings
            // 
            this.lbSettings.AutoSize = true;
            this.lbSettings.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSettings.Location = new System.Drawing.Point(149, 9);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(201, 33);
            this.lbSettings.TabIndex = 0;
            this.lbSettings.Text = "Rotors Settings";
            // 
            // gbDefaultRotors
            // 
            this.gbDefaultRotors.BackColor = System.Drawing.Color.White;
            this.gbDefaultRotors.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbDefaultRotors.Location = new System.Drawing.Point(21, 58);
            this.gbDefaultRotors.Name = "gbDefaultRotors";
            this.gbDefaultRotors.Size = new System.Drawing.Size(200, 228);
            this.gbDefaultRotors.TabIndex = 1;
            this.gbDefaultRotors.TabStop = false;
            this.gbDefaultRotors.Text = "Default Rotors";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(322, 448);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 29);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // RotorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 489);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbDefaultRotors);
            this.Controls.Add(this.lbSettings);
            this.Name = "RotorsForm";
            this.Text = "Rotors Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.GroupBox gbDefaultRotors;
        private System.Windows.Forms.Button btnOK;
    }
}