namespace EnigmaMachine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpDownR1 = new System.Windows.Forms.NumericUpDown();
            this.UpDownR2 = new System.Windows.Forms.NumericUpDown();
            this.UpDownR3 = new System.Windows.Forms.NumericUpDown();
            this.lbR1 = new System.Windows.Forms.Label();
            this.lbR2 = new System.Windows.Forms.Label();
            this.lbR3 = new System.Windows.Forms.Label();
            this.lbEnterWord = new System.Windows.Forms.Label();
            this.lbEnigmaCode = new System.Windows.Forms.Label();
            this.lbTopSecret = new System.Windows.Forms.Label();
            this.btnSavePositions = new System.Windows.Forms.Button();
            this.lbSave1 = new System.Windows.Forms.Label();
            this.lbSave2 = new System.Windows.Forms.Label();
            this.lbSave3 = new System.Windows.Forms.Label();
            this.btnSetPositions = new System.Windows.Forms.Button();
            this.lbPairCounter = new System.Windows.Forms.Label();
            this.lbNumericPairCounter = new System.Windows.Forms.Label();
            this.btnUnplug = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KeyBoardPanel = new System.Windows.Forms.Panel();
            this.lbKeyBoard = new System.Windows.Forms.Label();
            this.lbInsert = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.KeyBoardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpDownR1
            // 
            this.UpDownR1.BackColor = System.Drawing.SystemColors.Control;
            this.UpDownR1.Font = new System.Drawing.Font("Showcard Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDownR1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.UpDownR1.Location = new System.Drawing.Point(43, 60);
            this.UpDownR1.Maximum = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.UpDownR1.Name = "UpDownR1";
            this.UpDownR1.ReadOnly = true;
            this.UpDownR1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpDownR1.Size = new System.Drawing.Size(84, 50);
            this.UpDownR1.TabIndex = 0;
            this.UpDownR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownR1.ValueChanged += new System.EventHandler(this.UpDownR1_ValueChanged);
            // 
            // UpDownR2
            // 
            this.UpDownR2.BackColor = System.Drawing.SystemColors.Control;
            this.UpDownR2.Font = new System.Drawing.Font("Showcard Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDownR2.Location = new System.Drawing.Point(152, 60);
            this.UpDownR2.Maximum = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.UpDownR2.Name = "UpDownR2";
            this.UpDownR2.ReadOnly = true;
            this.UpDownR2.Size = new System.Drawing.Size(84, 50);
            this.UpDownR2.TabIndex = 1;
            this.UpDownR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownR2.ValueChanged += new System.EventHandler(this.UpDownR2_ValueChanged);
            // 
            // UpDownR3
            // 
            this.UpDownR3.BackColor = System.Drawing.SystemColors.Control;
            this.UpDownR3.Font = new System.Drawing.Font("Showcard Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDownR3.Location = new System.Drawing.Point(262, 60);
            this.UpDownR3.Maximum = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.UpDownR3.Name = "UpDownR3";
            this.UpDownR3.ReadOnly = true;
            this.UpDownR3.Size = new System.Drawing.Size(84, 50);
            this.UpDownR3.TabIndex = 2;
            this.UpDownR3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownR3.ValueChanged += new System.EventHandler(this.UpDownR3_ValueChanged);
            // 
            // lbR1
            // 
            this.lbR1.AutoSize = true;
            this.lbR1.BackColor = System.Drawing.SystemColors.Control;
            this.lbR1.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR1.Location = new System.Drawing.Point(39, 12);
            this.lbR1.Name = "lbR1";
            this.lbR1.Size = new System.Drawing.Size(93, 23);
            this.lbR1.TabIndex = 3;
            this.lbR1.Text = "ROTOR 1";
            // 
            // lbR2
            // 
            this.lbR2.AutoSize = true;
            this.lbR2.BackColor = System.Drawing.SystemColors.Control;
            this.lbR2.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR2.Location = new System.Drawing.Point(148, 12);
            this.lbR2.Name = "lbR2";
            this.lbR2.Size = new System.Drawing.Size(93, 23);
            this.lbR2.TabIndex = 4;
            this.lbR2.Text = "ROTOR 2";
            // 
            // lbR3
            // 
            this.lbR3.AutoSize = true;
            this.lbR3.BackColor = System.Drawing.SystemColors.Control;
            this.lbR3.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR3.Location = new System.Drawing.Point(258, 12);
            this.lbR3.Name = "lbR3";
            this.lbR3.Size = new System.Drawing.Size(93, 23);
            this.lbR3.TabIndex = 5;
            this.lbR3.Text = "ROTOR 3";
            // 
            // lbEnterWord
            // 
            this.lbEnterWord.AutoSize = true;
            this.lbEnterWord.BackColor = System.Drawing.SystemColors.Control;
            this.lbEnterWord.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterWord.Location = new System.Drawing.Point(121, 462);
            this.lbEnterWord.Name = "lbEnterWord";
            this.lbEnterWord.Size = new System.Drawing.Size(133, 30);
            this.lbEnterWord.TabIndex = 7;
            this.lbEnterWord.Text = "Your Word";
            // 
            // lbEnigmaCode
            // 
            this.lbEnigmaCode.AutoSize = true;
            this.lbEnigmaCode.BackColor = System.Drawing.SystemColors.Control;
            this.lbEnigmaCode.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnigmaCode.Location = new System.Drawing.Point(621, 462);
            this.lbEnigmaCode.Name = "lbEnigmaCode";
            this.lbEnigmaCode.Size = new System.Drawing.Size(172, 30);
            this.lbEnigmaCode.TabIndex = 9;
            this.lbEnigmaCode.Text = "Enigma Code";
            // 
            // lbTopSecret
            // 
            this.lbTopSecret.AutoSize = true;
            this.lbTopSecret.BackColor = System.Drawing.SystemColors.Control;
            this.lbTopSecret.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopSecret.Location = new System.Drawing.Point(703, 9);
            this.lbTopSecret.Name = "lbTopSecret";
            this.lbTopSecret.Size = new System.Drawing.Size(162, 33);
            this.lbTopSecret.TabIndex = 12;
            this.lbTopSecret.Text = "TOP SECRET";
            // 
            // btnSavePositions
            // 
            this.btnSavePositions.BackColor = System.Drawing.SystemColors.Control;
            this.btnSavePositions.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSavePositions.Location = new System.Drawing.Point(152, 135);
            this.btnSavePositions.Name = "btnSavePositions";
            this.btnSavePositions.Size = new System.Drawing.Size(84, 27);
            this.btnSavePositions.TabIndex = 13;
            this.btnSavePositions.Text = "Save";
            this.btnSavePositions.UseVisualStyleBackColor = false;
            this.btnSavePositions.Click += new System.EventHandler(this.btnSavePositions_Click);
            // 
            // lbSave1
            // 
            this.lbSave1.AutoSize = true;
            this.lbSave1.BackColor = System.Drawing.SystemColors.Control;
            this.lbSave1.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSave1.Location = new System.Drawing.Point(707, 56);
            this.lbSave1.Name = "lbSave1";
            this.lbSave1.Size = new System.Drawing.Size(21, 22);
            this.lbSave1.TabIndex = 14;
            this.lbSave1.Text = "0";
            // 
            // lbSave2
            // 
            this.lbSave2.AutoSize = true;
            this.lbSave2.BackColor = System.Drawing.SystemColors.Control;
            this.lbSave2.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSave2.Location = new System.Drawing.Point(772, 56);
            this.lbSave2.Name = "lbSave2";
            this.lbSave2.Size = new System.Drawing.Size(21, 22);
            this.lbSave2.TabIndex = 15;
            this.lbSave2.Text = "0";
            // 
            // lbSave3
            // 
            this.lbSave3.AutoSize = true;
            this.lbSave3.BackColor = System.Drawing.SystemColors.Control;
            this.lbSave3.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSave3.Location = new System.Drawing.Point(835, 56);
            this.lbSave3.Name = "lbSave3";
            this.lbSave3.Size = new System.Drawing.Size(21, 22);
            this.lbSave3.TabIndex = 16;
            this.lbSave3.Text = "0";
            // 
            // btnSetPositions
            // 
            this.btnSetPositions.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetPositions.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPositions.Location = new System.Drawing.Point(711, 90);
            this.btnSetPositions.Name = "btnSetPositions";
            this.btnSetPositions.Size = new System.Drawing.Size(145, 37);
            this.btnSetPositions.TabIndex = 17;
            this.btnSetPositions.Text = "Set Positions";
            this.btnSetPositions.UseVisualStyleBackColor = false;
            this.btnSetPositions.Click += new System.EventHandler(this.btnSetPositions_Click);
            // 
            // lbPairCounter
            // 
            this.lbPairCounter.AutoSize = true;
            this.lbPairCounter.BackColor = System.Drawing.SystemColors.Control;
            this.lbPairCounter.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPairCounter.Location = new System.Drawing.Point(478, 167);
            this.lbPairCounter.Name = "lbPairCounter";
            this.lbPairCounter.Size = new System.Drawing.Size(82, 16);
            this.lbPairCounter.TabIndex = 19;
            this.lbPairCounter.Text = "Pairs left : ";
            // 
            // lbNumericPairCounter
            // 
            this.lbNumericPairCounter.AutoSize = true;
            this.lbNumericPairCounter.BackColor = System.Drawing.SystemColors.Control;
            this.lbNumericPairCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumericPairCounter.Location = new System.Drawing.Point(557, 167);
            this.lbNumericPairCounter.Name = "lbNumericPairCounter";
            this.lbNumericPairCounter.Size = new System.Drawing.Size(26, 17);
            this.lbNumericPairCounter.TabIndex = 20;
            this.lbNumericPairCounter.Text = "10";
            // 
            // btnUnplug
            // 
            this.btnUnplug.BackColor = System.Drawing.SystemColors.Control;
            this.btnUnplug.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUnplug.Location = new System.Drawing.Point(506, 130);
            this.btnUnplug.Name = "btnUnplug";
            this.btnUnplug.Size = new System.Drawing.Size(75, 34);
            this.btnUnplug.TabIndex = 21;
            this.btnUnplug.Text = "Unplug";
            this.btnUnplug.UseVisualStyleBackColor = false;
            this.btnUnplug.Click += new System.EventHandler(this.btnUnplug_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::EnigmaMachine.Properties.Resources.enigma3;
            this.pictureBox1.Location = new System.Drawing.Point(395, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 110);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // KeyBoardPanel
            // 
            this.KeyBoardPanel.BackColor = System.Drawing.Color.White;
            this.KeyBoardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyBoardPanel.Controls.Add(this.lbKeyBoard);
            this.KeyBoardPanel.Location = new System.Drawing.Point(-4, 594);
            this.KeyBoardPanel.Name = "KeyBoardPanel";
            this.KeyBoardPanel.Size = new System.Drawing.Size(906, 306);
            this.KeyBoardPanel.TabIndex = 23;
            // 
            // lbKeyBoard
            // 
            this.lbKeyBoard.AutoSize = true;
            this.lbKeyBoard.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKeyBoard.Location = new System.Drawing.Point(359, 0);
            this.lbKeyBoard.Name = "lbKeyBoard";
            this.lbKeyBoard.Size = new System.Drawing.Size(169, 39);
            this.lbKeyBoard.TabIndex = 0;
            this.lbKeyBoard.Text = "Keyboard";
            // 
            // lbInsert
            // 
            this.lbInsert.AutoSize = true;
            this.lbInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInsert.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInsert.Location = new System.Drawing.Point(46, 518);
            this.lbInsert.MinimumSize = new System.Drawing.Size(300, 41);
            this.lbInsert.Name = "lbInsert";
            this.lbInsert.Size = new System.Drawing.Size(300, 41);
            this.lbInsert.TabIndex = 24;
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOutput.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOutput.Location = new System.Drawing.Point(556, 518);
            this.lbOutput.MinimumSize = new System.Drawing.Size(300, 41);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(300, 41);
            this.lbOutput.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 898);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lbInsert);
            this.Controls.Add(this.KeyBoardPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUnplug);
            this.Controls.Add(this.lbNumericPairCounter);
            this.Controls.Add(this.lbPairCounter);
            this.Controls.Add(this.btnSetPositions);
            this.Controls.Add(this.lbSave3);
            this.Controls.Add(this.lbSave2);
            this.Controls.Add(this.lbSave1);
            this.Controls.Add(this.btnSavePositions);
            this.Controls.Add(this.lbTopSecret);
            this.Controls.Add(this.lbEnigmaCode);
            this.Controls.Add(this.lbEnterWord);
            this.Controls.Add(this.lbR3);
            this.Controls.Add(this.lbR2);
            this.Controls.Add(this.lbR1);
            this.Controls.Add(this.UpDownR3);
            this.Controls.Add(this.UpDownR2);
            this.Controls.Add(this.UpDownR1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "ENIGMA";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.KeyBoardPanel.ResumeLayout(false);
            this.KeyBoardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UpDownR1;
        private System.Windows.Forms.NumericUpDown UpDownR2;
        private System.Windows.Forms.NumericUpDown UpDownR3;
        private System.Windows.Forms.Label lbR1;
        private System.Windows.Forms.Label lbR2;
        private System.Windows.Forms.Label lbR3;
        private System.Windows.Forms.Label lbEnterWord;
        private System.Windows.Forms.Label lbEnigmaCode;
        private System.Windows.Forms.Label lbTopSecret;
        private System.Windows.Forms.Button btnSavePositions;
        private System.Windows.Forms.Label lbSave1;
        private System.Windows.Forms.Label lbSave2;
        private System.Windows.Forms.Label lbSave3;
        private System.Windows.Forms.Button btnSetPositions;
        private System.Windows.Forms.Label lbPairCounter;
        private System.Windows.Forms.Label lbNumericPairCounter;
        private System.Windows.Forms.Button btnUnplug;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel KeyBoardPanel;
        private System.Windows.Forms.Label lbKeyBoard;
        private System.Windows.Forms.Label lbInsert;
        private System.Windows.Forms.Label lbOutput;
    }
}

