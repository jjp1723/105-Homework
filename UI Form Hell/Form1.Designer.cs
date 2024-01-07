namespace UI_Form_Hell
{
    partial class Form1
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
            this.timeButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.lowButton = new System.Windows.Forms.Button();
            this.timeErrorBox = new System.Windows.Forms.TextBox();
            this.highErrorBox = new System.Windows.Forms.TextBox();
            this.lowErrorBox = new System.Windows.Forms.TextBox();
            this.readyButton = new System.Windows.Forms.Button();
            this.directionLabel = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.highBox = new System.Windows.Forms.TextBox();
            this.lowBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(40, 89);
            this.timeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(186, 130);
            this.timeButton.TabIndex = 31;
            this.timeButton.Text = "Enter";
            this.timeButton.UseVisualStyleBackColor = true;
            this.timeButton.MouseEnter += new System.EventHandler(this.EnterTimeClick);
            // 
            // highButton
            // 
            this.highButton.Location = new System.Drawing.Point(421, 89);
            this.highButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(175, 130);
            this.highButton.TabIndex = 30;
            this.highButton.Text = "Enter";
            this.highButton.UseVisualStyleBackColor = true;
            this.highButton.MouseEnter += new System.EventHandler(this.EnterHighClick);
            // 
            // lowButton
            // 
            this.lowButton.Location = new System.Drawing.Point(232, 89);
            this.lowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(183, 130);
            this.lowButton.TabIndex = 29;
            this.lowButton.Text = "Enter";
            this.lowButton.UseVisualStyleBackColor = true;
            this.lowButton.MouseEnter += new System.EventHandler(this.EnterLowClick);
            // 
            // timeErrorBox
            // 
            this.timeErrorBox.Enabled = false;
            this.timeErrorBox.Location = new System.Drawing.Point(232, 225);
            this.timeErrorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeErrorBox.Name = "timeErrorBox";
            this.timeErrorBox.Size = new System.Drawing.Size(183, 22);
            this.timeErrorBox.TabIndex = 28;
            // 
            // highErrorBox
            // 
            this.highErrorBox.Enabled = false;
            this.highErrorBox.Location = new System.Drawing.Point(40, 225);
            this.highErrorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highErrorBox.Name = "highErrorBox";
            this.highErrorBox.Size = new System.Drawing.Size(184, 22);
            this.highErrorBox.TabIndex = 27;
            // 
            // lowErrorBox
            // 
            this.lowErrorBox.Enabled = false;
            this.lowErrorBox.Location = new System.Drawing.Point(423, 225);
            this.lowErrorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lowErrorBox.Name = "lowErrorBox";
            this.lowErrorBox.Size = new System.Drawing.Size(173, 22);
            this.lowErrorBox.TabIndex = 26;
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(40, 309);
            this.readyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(557, 26);
            this.readyButton.TabIndex = 25;
            this.readyButton.Text = "Ready";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.ReadyClick);
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(332, 12);
            this.directionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(290, 17);
            this.directionLabel.TabIndex = 23;
            this.directionLabel.Text = "Enter the range for the number and the time.";
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(9, 12);
            this.greetingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(325, 17);
            this.greetingLabel.TabIndex = 22;
            this.greetingLabel.Text = "Hello, and welcome to the number guessing game!";
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(423, 61);
            this.timeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(173, 22);
            this.timeBox.TabIndex = 18;
            // 
            // highBox
            // 
            this.highBox.Location = new System.Drawing.Point(232, 61);
            this.highBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highBox.Name = "highBox";
            this.highBox.Size = new System.Drawing.Size(183, 22);
            this.highBox.TabIndex = 17;
            // 
            // lowBox
            // 
            this.lowBox.Location = new System.Drawing.Point(40, 61);
            this.lowBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lowBox.Name = "lowBox";
            this.lowBox.Size = new System.Drawing.Size(184, 22);
            this.lowBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 350);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.lowButton);
            this.Controls.Add(this.timeErrorBox);
            this.Controls.Add(this.highErrorBox);
            this.Controls.Add(this.lowErrorBox);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.directionLabel);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.highBox);
            this.Controls.Add(this.lowBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timeButton;
        private System.Windows.Forms.Button highButton;
        private System.Windows.Forms.Button lowButton;
        private System.Windows.Forms.TextBox timeErrorBox;
        private System.Windows.Forms.TextBox highErrorBox;
        private System.Windows.Forms.TextBox lowErrorBox;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox highBox;
        private System.Windows.Forms.TextBox lowBox;
    }
}

