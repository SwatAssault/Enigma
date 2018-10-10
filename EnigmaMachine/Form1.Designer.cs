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
            this.btnSetPositions = new System.Windows.Forms.Button();
            this.lbPairCounter = new System.Windows.Forms.Label();
            this.lbNumericPairCounter = new System.Windows.Forms.Label();
            this.btnUnplug = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KeyBoardPanel = new System.Windows.Forms.Panel();
            this.btnShowPlugboard = new System.Windows.Forms.Button();
            this.lbKeyBoard = new System.Windows.Forms.Label();
            this.PlugboardPanel = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.lbPlugboard = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.tbInsert = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lbSave1 = new System.Windows.Forms.Label();
            this.lbSave2 = new System.Windows.Forms.Label();
            this.lbSave3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.KeyBoardPanel.SuspendLayout();
            this.PlugboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpDownR1
            // 
            this.UpDownR1.BackColor = System.Drawing.SystemColors.Control;
            this.UpDownR1.Font = new System.Drawing.Font("Showcard Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDownR1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.UpDownR1.Location = new System.Drawing.Point(262, 60);
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
            this.UpDownR3.Location = new System.Drawing.Point(43, 60);
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
            this.lbR1.BackColor = System.Drawing.Color.Transparent;
            this.lbR1.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR1.Location = new System.Drawing.Point(258, 12);
            this.lbR1.Name = "lbR1";
            this.lbR1.Size = new System.Drawing.Size(93, 23);
            this.lbR1.TabIndex = 3;
            this.lbR1.Text = "ROTOR 1";
            // 
            // lbR2
            // 
            this.lbR2.AutoSize = true;
            this.lbR2.BackColor = System.Drawing.Color.Transparent;
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
            this.lbR3.BackColor = System.Drawing.Color.Transparent;
            this.lbR3.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR3.Location = new System.Drawing.Point(39, 12);
            this.lbR3.Name = "lbR3";
            this.lbR3.Size = new System.Drawing.Size(93, 23);
            this.lbR3.TabIndex = 5;
            this.lbR3.Text = "ROTOR 3";
            // 
            // lbEnterWord
            // 
            this.lbEnterWord.AutoSize = true;
            this.lbEnterWord.BackColor = System.Drawing.Color.Transparent;
            this.lbEnterWord.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterWord.Location = new System.Drawing.Point(122, 471);
            this.lbEnterWord.Name = "lbEnterWord";
            this.lbEnterWord.Size = new System.Drawing.Size(133, 30);
            this.lbEnterWord.TabIndex = 7;
            this.lbEnterWord.Text = "Your Word";
            // 
            // lbEnigmaCode
            // 
            this.lbEnigmaCode.AutoSize = true;
            this.lbEnigmaCode.BackColor = System.Drawing.Color.Transparent;
            this.lbEnigmaCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEnigmaCode.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnigmaCode.Location = new System.Drawing.Point(621, 471);
            this.lbEnigmaCode.Name = "lbEnigmaCode";
            this.lbEnigmaCode.Size = new System.Drawing.Size(172, 30);
            this.lbEnigmaCode.TabIndex = 9;
            this.lbEnigmaCode.Text = "Enigma Code";
            // 
            // lbTopSecret
            // 
            this.lbTopSecret.AutoSize = true;
            this.lbTopSecret.BackColor = System.Drawing.Color.Transparent;
            this.lbTopSecret.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopSecret.Location = new System.Drawing.Point(639, 9);
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
            // btnSetPositions
            // 
            this.btnSetPositions.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetPositions.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPositions.Location = new System.Drawing.Point(648, 85);
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
            this.lbPairCounter.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPairCounter.Location = new System.Drawing.Point(401, 24);
            this.lbPairCounter.Name = "lbPairCounter";
            this.lbPairCounter.Size = new System.Drawing.Size(85, 21);
            this.lbPairCounter.TabIndex = 19;
            this.lbPairCounter.Text = "Pairs left : ";
            // 
            // lbNumericPairCounter
            // 
            this.lbNumericPairCounter.AutoSize = true;
            this.lbNumericPairCounter.BackColor = System.Drawing.SystemColors.Control;
            this.lbNumericPairCounter.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumericPairCounter.Location = new System.Drawing.Point(489, 24);
            this.lbNumericPairCounter.Name = "lbNumericPairCounter";
            this.lbNumericPairCounter.Size = new System.Drawing.Size(28, 21);
            this.lbNumericPairCounter.TabIndex = 20;
            this.lbNumericPairCounter.Text = "10";
            // 
            // btnUnplug
            // 
            this.btnUnplug.BackColor = System.Drawing.SystemColors.Control;
            this.btnUnplug.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUnplug.Location = new System.Drawing.Point(43, 19);
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
            this.pictureBox1.Location = new System.Drawing.Point(366, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 110);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // KeyBoardPanel
            // 
            this.KeyBoardPanel.BackColor = System.Drawing.Color.White;
            this.KeyBoardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyBoardPanel.Controls.Add(this.btnShowPlugboard);
            this.KeyBoardPanel.Controls.Add(this.lbKeyBoard);
            this.KeyBoardPanel.Location = new System.Drawing.Point(-1, 594);
            this.KeyBoardPanel.Name = "KeyBoardPanel";
            this.KeyBoardPanel.Size = new System.Drawing.Size(917, 306);
            this.KeyBoardPanel.TabIndex = 23;
            // 
            // btnShowPlugboard
            // 
            this.btnShowPlugboard.BackColor = System.Drawing.Color.White;
            this.btnShowPlugboard.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowPlugboard.Location = new System.Drawing.Point(712, 9);
            this.btnShowPlugboard.Name = "btnShowPlugboard";
            this.btnShowPlugboard.Size = new System.Drawing.Size(148, 36);
            this.btnShowPlugboard.TabIndex = 27;
            this.btnShowPlugboard.Text = "Show Plugboard";
            this.btnShowPlugboard.UseVisualStyleBackColor = false;
            this.btnShowPlugboard.Click += new System.EventHandler(this.btnShowPlugboard_Click);
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
            // PlugboardPanel
            // 
            this.PlugboardPanel.BackColor = System.Drawing.Color.White;
            this.PlugboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlugboardPanel.Controls.Add(this.btnHide);
            this.PlugboardPanel.Controls.Add(this.lbPlugboard);
            this.PlugboardPanel.Controls.Add(this.btnUnplug);
            this.PlugboardPanel.Controls.Add(this.lbPairCounter);
            this.PlugboardPanel.Controls.Add(this.lbNumericPairCounter);
            this.PlugboardPanel.Location = new System.Drawing.Point(-1, 544);
            this.PlugboardPanel.Name = "PlugboardPanel";
            this.PlugboardPanel.Size = new System.Drawing.Size(901, 356);
            this.PlugboardPanel.TabIndex = 26;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.White;
            this.btnHide.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHide.Location = new System.Drawing.Point(771, 15);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(115, 38);
            this.btnHide.TabIndex = 22;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // lbPlugboard
            // 
            this.lbPlugboard.AutoSize = true;
            this.lbPlugboard.Font = new System.Drawing.Font("Century Gothic", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlugboard.Location = new System.Drawing.Point(183, 14);
            this.lbPlugboard.Name = "lbPlugboard";
            this.lbPlugboard.Size = new System.Drawing.Size(168, 38);
            this.lbPlugboard.TabIndex = 0;
            this.lbPlugboard.Text = "Plugboard";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.BorderSize = 5;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(43, 135);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 27);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.White;
            this.btnClean.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.Location = new System.Drawing.Point(405, 518);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(92, 41);
            this.btnClean.TabIndex = 28;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // tbInsert
            // 
            this.tbInsert.Font = new System.Drawing.Font("Century Gothic", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInsert.Location = new System.Drawing.Point(46, 518);
            this.tbInsert.MaximumSize = new System.Drawing.Size(300, 41);
            this.tbInsert.MinimumSize = new System.Drawing.Size(300, 41);
            this.tbInsert.Name = "tbInsert";
            this.tbInsert.ReadOnly = true;
            this.tbInsert.Size = new System.Drawing.Size(300, 43);
            this.tbInsert.TabIndex = 29;
            // 
            // tbOutput
            // 
            this.tbOutput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOutput.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput.Location = new System.Drawing.Point(556, 518);
            this.tbOutput.MaximumSize = new System.Drawing.Size(300, 40);
            this.tbOutput.MinimumSize = new System.Drawing.Size(300, 40);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(300, 43);
            this.tbOutput.TabIndex = 30;
            // 
            // lbSave1
            // 
            this.lbSave1.AutoSize = true;
            this.lbSave1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSave1.Location = new System.Drawing.Point(767, 51);
            this.lbSave1.Name = "lbSave1";
            this.lbSave1.Size = new System.Drawing.Size(21, 23);
            this.lbSave1.TabIndex = 31;
            this.lbSave1.Text = "0";
            // 
            // lbSave2
            // 
            this.lbSave2.AutoSize = true;
            this.lbSave2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSave2.Location = new System.Drawing.Point(708, 51);
            this.lbSave2.Name = "lbSave2";
            this.lbSave2.Size = new System.Drawing.Size(21, 23);
            this.lbSave2.TabIndex = 32;
            this.lbSave2.Text = "0";
            // 
            // lbSave3
            // 
            this.lbSave3.AutoSize = true;
            this.lbSave3.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSave3.Location = new System.Drawing.Point(652, 51);
            this.lbSave3.Name = "lbSave3";
            this.lbSave3.Size = new System.Drawing.Size(21, 23);
            this.lbSave3.TabIndex = 33;
            this.lbSave3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 898);
            this.Controls.Add(this.lbSave3);
            this.Controls.Add(this.lbSave2);
            this.Controls.Add(this.lbSave1);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInsert);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.PlugboardPanel);
            this.Controls.Add(this.KeyBoardPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSetPositions);
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
            this.MaximumSize = new System.Drawing.Size(914, 936);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENIGMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.KeyBoardPanel.ResumeLayout(false);
            this.KeyBoardPanel.PerformLayout();
            this.PlugboardPanel.ResumeLayout(false);
            this.PlugboardPanel.PerformLayout();
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
        private System.Windows.Forms.Button btnSetPositions;
        private System.Windows.Forms.Label lbPairCounter;
        private System.Windows.Forms.Label lbNumericPairCounter;
        private System.Windows.Forms.Button btnUnplug;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel KeyBoardPanel;
        private System.Windows.Forms.Label lbKeyBoard;
        private System.Windows.Forms.Panel PlugboardPanel;
        private System.Windows.Forms.Label lbPlugboard;
        private System.Windows.Forms.Button btnShowPlugboard;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox tbInsert;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lbSave1;
        private System.Windows.Forms.Label lbSave2;
        private System.Windows.Forms.Label lbSave3;
    }
}

