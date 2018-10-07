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
            this.tbInsert = new System.Windows.Forms.TextBox();
            this.lbEnterWord = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lbEnigmaCode = new System.Windows.Forms.Label();
            this.lbTopSecret = new System.Windows.Forms.Label();
            this.btnSavePositions = new System.Windows.Forms.Button();
            this.lbSave1 = new System.Windows.Forms.Label();
            this.lbSave2 = new System.Windows.Forms.Label();
            this.lbSave3 = new System.Windows.Forms.Label();
            this.btnSetPositions = new System.Windows.Forms.Button();
            this.lbPlugboard_Click = new System.Windows.Forms.Label();
            this.lbPairCounter = new System.Windows.Forms.Label();
            this.lbNumericPairCounter = new System.Windows.Forms.Label();
            this.btnUnplug = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpDownR1
            // 
            this.UpDownR1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UpDownR1.Font = new System.Drawing.Font("Showcard Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDownR1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.UpDownR1.Location = new System.Drawing.Point(49, 98);
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
            this.UpDownR2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UpDownR2.Font = new System.Drawing.Font("Showcard Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDownR2.Location = new System.Drawing.Point(158, 98);
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
            this.UpDownR3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UpDownR3.Font = new System.Drawing.Font("Showcard Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpDownR3.Location = new System.Drawing.Point(268, 98);
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
            this.lbR1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbR1.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbR1.Location = new System.Drawing.Point(45, 50);
            this.lbR1.Name = "lbR1";
            this.lbR1.Size = new System.Drawing.Size(100, 24);
            this.lbR1.TabIndex = 3;
            this.lbR1.Text = "ROTOR 1";
            // 
            // lbR2
            // 
            this.lbR2.AutoSize = true;
            this.lbR2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbR2.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbR2.Location = new System.Drawing.Point(154, 50);
            this.lbR2.Name = "lbR2";
            this.lbR2.Size = new System.Drawing.Size(100, 24);
            this.lbR2.TabIndex = 4;
            this.lbR2.Text = "ROTOR 2";
            // 
            // lbR3
            // 
            this.lbR3.AutoSize = true;
            this.lbR3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbR3.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbR3.Location = new System.Drawing.Point(264, 50);
            this.lbR3.Name = "lbR3";
            this.lbR3.Size = new System.Drawing.Size(100, 24);
            this.lbR3.TabIndex = 5;
            this.lbR3.Text = "ROTOR 3";
            // 
            // tbInsert
            // 
            this.tbInsert.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbInsert.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbInsert.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInsert.Location = new System.Drawing.Point(74, 642);
            this.tbInsert.Name = "tbInsert";
            this.tbInsert.Size = new System.Drawing.Size(263, 41);
            this.tbInsert.TabIndex = 6;
            this.tbInsert.TextChanged += new System.EventHandler(this.tbInsert_TextChanged);
            this.tbInsert.DoubleClick += new System.EventHandler(this.tbInsert_DoubleClick);
            this.tbInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyDown);
            this.tbInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            this.tbInsert.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_KeyUp);
            // 
            // lbEnterWord
            // 
            this.lbEnterWord.AutoSize = true;
            this.lbEnterWord.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbEnterWord.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEnterWord.Location = new System.Drawing.Point(102, 601);
            this.lbEnterWord.Name = "lbEnterWord";
            this.lbEnterWord.Size = new System.Drawing.Size(202, 29);
            this.lbEnterWord.TabIndex = 7;
            this.lbEnterWord.Text = "Enter your Word";
            // 
            // tbOutput
            // 
            this.tbOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbOutput.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOutput.Location = new System.Drawing.Point(559, 642);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(263, 41);
            this.tbOutput.TabIndex = 8;
            // 
            // lbEnigmaCode
            // 
            this.lbEnigmaCode.AutoSize = true;
            this.lbEnigmaCode.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbEnigmaCode.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEnigmaCode.Location = new System.Drawing.Point(602, 601);
            this.lbEnigmaCode.Name = "lbEnigmaCode";
            this.lbEnigmaCode.Size = new System.Drawing.Size(167, 29);
            this.lbEnigmaCode.TabIndex = 9;
            this.lbEnigmaCode.Text = "Enigma Code";
            // 
            // lbTopSecret
            // 
            this.lbTopSecret.AutoSize = true;
            this.lbTopSecret.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbTopSecret.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTopSecret.Location = new System.Drawing.Point(694, 50);
            this.lbTopSecret.Name = "lbTopSecret";
            this.lbTopSecret.Size = new System.Drawing.Size(192, 32);
            this.lbTopSecret.TabIndex = 12;
            this.lbTopSecret.Text = "TOP SECRET";
            // 
            // btnSavePositions
            // 
            this.btnSavePositions.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSavePositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSavePositions.Location = new System.Drawing.Point(158, 173);
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
            this.lbSave1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbSave1.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSave1.Location = new System.Drawing.Point(713, 94);
            this.lbSave1.Name = "lbSave1";
            this.lbSave1.Size = new System.Drawing.Size(21, 22);
            this.lbSave1.TabIndex = 14;
            this.lbSave1.Text = "0";
            // 
            // lbSave2
            // 
            this.lbSave2.AutoSize = true;
            this.lbSave2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbSave2.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSave2.Location = new System.Drawing.Point(778, 94);
            this.lbSave2.Name = "lbSave2";
            this.lbSave2.Size = new System.Drawing.Size(21, 22);
            this.lbSave2.TabIndex = 15;
            this.lbSave2.Text = "0";
            // 
            // lbSave3
            // 
            this.lbSave3.AutoSize = true;
            this.lbSave3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbSave3.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSave3.Location = new System.Drawing.Point(841, 94);
            this.lbSave3.Name = "lbSave3";
            this.lbSave3.Size = new System.Drawing.Size(21, 22);
            this.lbSave3.TabIndex = 16;
            this.lbSave3.Text = "0";
            // 
            // btnSetPositions
            // 
            this.btnSetPositions.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSetPositions.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetPositions.Location = new System.Drawing.Point(717, 128);
            this.btnSetPositions.Name = "btnSetPositions";
            this.btnSetPositions.Size = new System.Drawing.Size(145, 37);
            this.btnSetPositions.TabIndex = 17;
            this.btnSetPositions.Text = "Set Positions";
            this.btnSetPositions.UseVisualStyleBackColor = false;
            this.btnSetPositions.Click += new System.EventHandler(this.btnSetPositions_Click);
            // 
            // lbPlugboard_Click
            // 
            this.lbPlugboard_Click.AutoSize = true;
            this.lbPlugboard_Click.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbPlugboard_Click.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPlugboard_Click.Location = new System.Drawing.Point(367, 688);
            this.lbPlugboard_Click.Name = "lbPlugboard_Click";
            this.lbPlugboard_Click.Size = new System.Drawing.Size(162, 35);
            this.lbPlugboard_Click.TabIndex = 18;
            this.lbPlugboard_Click.Text = "Plugboard";
            // 
            // lbPairCounter
            // 
            this.lbPairCounter.AutoSize = true;
            this.lbPairCounter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbPairCounter.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPairCounter.Location = new System.Drawing.Point(392, 732);
            this.lbPairCounter.Name = "lbPairCounter";
            this.lbPairCounter.Size = new System.Drawing.Size(82, 16);
            this.lbPairCounter.TabIndex = 19;
            this.lbPairCounter.Text = "Pairs left : ";
            // 
            // lbNumericPairCounter
            // 
            this.lbNumericPairCounter.AutoSize = true;
            this.lbNumericPairCounter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbNumericPairCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumericPairCounter.Location = new System.Drawing.Point(471, 732);
            this.lbNumericPairCounter.Name = "lbNumericPairCounter";
            this.lbNumericPairCounter.Size = new System.Drawing.Size(26, 17);
            this.lbNumericPairCounter.TabIndex = 20;
            this.lbNumericPairCounter.Text = "10";
            // 
            // btnUnplug
            // 
            this.btnUnplug.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUnplug.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUnplug.Location = new System.Drawing.Point(747, 692);
            this.btnUnplug.Name = "btnUnplug";
            this.btnUnplug.Size = new System.Drawing.Size(75, 34);
            this.btnUnplug.TabIndex = 21;
            this.btnUnplug.Text = "Unplug";
            this.btnUnplug.UseVisualStyleBackColor = false;
            this.btnUnplug.Click += new System.EventHandler(this.btnUnplug_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnigmaMachine.Properties.Resources.enigma2;
            this.pictureBox1.Location = new System.Drawing.Point(401, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 110);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(395, 642);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 41);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EnigmaMachine.Properties.Resources.leatherforenigma1;
            this.ClientSize = new System.Drawing.Size(898, 1054);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUnplug);
            this.Controls.Add(this.lbNumericPairCounter);
            this.Controls.Add(this.lbPairCounter);
            this.Controls.Add(this.lbPlugboard_Click);
            this.Controls.Add(this.btnSetPositions);
            this.Controls.Add(this.lbSave3);
            this.Controls.Add(this.lbSave2);
            this.Controls.Add(this.lbSave1);
            this.Controls.Add(this.btnSavePositions);
            this.Controls.Add(this.lbTopSecret);
            this.Controls.Add(this.lbEnigmaCode);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.lbEnterWord);
            this.Controls.Add(this.tbInsert);
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
        private System.Windows.Forms.TextBox tbInsert;
        private System.Windows.Forms.Label lbEnterWord;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lbEnigmaCode;
        private System.Windows.Forms.Label lbTopSecret;
        private System.Windows.Forms.Button btnSavePositions;
        private System.Windows.Forms.Label lbSave1;
        private System.Windows.Forms.Label lbSave2;
        private System.Windows.Forms.Label lbSave3;
        private System.Windows.Forms.Button btnSetPositions;
        private System.Windows.Forms.Label lbPlugboard_Click;
        private System.Windows.Forms.Label lbPairCounter;
        private System.Windows.Forms.Label lbNumericPairCounter;
        private System.Windows.Forms.Button btnUnplug;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

