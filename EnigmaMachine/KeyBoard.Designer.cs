namespace EnigmaMachine
{
    partial class KeyBoard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbKeyboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKeyboard
            // 
            this.lbKeyboard.AutoSize = true;
            this.lbKeyboard.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKeyboard.Location = new System.Drawing.Point(370, 11);
            this.lbKeyboard.Name = "lbKeyboard";
            this.lbKeyboard.Size = new System.Drawing.Size(161, 37);
            this.lbKeyboard.TabIndex = 0;
            this.lbKeyboard.Text = "Keyboard";
            // 
            // KeyBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.lbKeyboard);
            this.Name = "KeyBoard";
            this.Size = new System.Drawing.Size(914, 331);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKeyboard;
    }
}
