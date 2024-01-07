namespace UI_Form_Hell
{
    partial class Guess
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
            this.guessButton = new System.Windows.Forms.Button();
            this.guessBox = new System.Windows.Forms.ComboBox();
            this.guessCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(16, 48);
            this.guessButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(1035, 491);
            this.guessButton.TabIndex = 0;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GuessButtonKey);
            // 
            // guessBox
            // 
            this.guessBox.FormattingEnabled = true;
            this.guessBox.Location = new System.Drawing.Point(16, 15);
            this.guessBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(160, 24);
            this.guessBox.TabIndex = 2;
            // 
            // guessCheck
            // 
            this.guessCheck.AutoSize = true;
            this.guessCheck.Location = new System.Drawing.Point(740, 12);
            this.guessCheck.Name = "guessCheck";
            this.guessCheck.Size = new System.Drawing.Size(311, 21);
            this.guessCheck.TabIndex = 3;
            this.guessCheck.Text = "Do you REALLY want to guess that number?";
            this.guessCheck.UseVisualStyleBackColor = true;
            this.guessCheck.CheckedChanged += new System.EventHandler(this.GuessCheck);
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.guessCheck);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.guessButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Guess";
            this.Text = "Guess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.ComboBox guessBox;
        private System.Windows.Forms.CheckBox guessCheck;
    }
}