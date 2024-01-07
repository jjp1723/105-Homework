namespace UI_Form_Hell
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.closeButton = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.guessButton = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(433, 80);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(42, 20);
            this.closeButton.TabIndex = 21;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.CloseClick);
            // 
            // messageBox
            // 
            this.messageBox.Enabled = false;
            this.messageBox.Location = new System.Drawing.Point(255, 11);
            this.messageBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(220, 20);
            this.messageBox.TabIndex = 20;
            this.messageBox.Visible = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(287, 35);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(188, 110);
            this.startButton.TabIndex = 19;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.MouseEnter += new System.EventHandler(this.StartClick);
            // 
            // guessButton
            // 
            this.guessButton.Enabled = false;
            this.guessButton.Location = new System.Drawing.Point(12, 12);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(237, 224);
            this.guessButton.TabIndex = 18;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.GuessClick);
            // 
            // outBox
            // 
            this.outBox.Enabled = false;
            this.outBox.Location = new System.Drawing.Point(255, 216);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(220, 20);
            this.outBox.TabIndex = 14;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 248);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.outBox);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.Timer timer;
    }
}