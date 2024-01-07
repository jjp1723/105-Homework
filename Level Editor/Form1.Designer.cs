namespace Level_Editor
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
            this.components = new System.ComponentModel.Container();
            this.loadButton = new System.Windows.Forms.Button();
            this.createBox = new System.Windows.Forms.PictureBox();
            this.createLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthError = new System.Windows.Forms.ErrorProvider(this.components);
            this.heightError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.createBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightError)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(13, 14);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(307, 85);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load Map";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadMap);
            // 
            // createBox
            // 
            this.createBox.Location = new System.Drawing.Point(13, 148);
            this.createBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(307, 231);
            this.createBox.TabIndex = 1;
            this.createBox.TabStop = false;
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Location = new System.Drawing.Point(11, 148);
            this.createLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(112, 17);
            this.createLabel.TabIndex = 2;
            this.createLabel.Text = "Create New Map";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(28, 295);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(277, 69);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create Map";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButtonClick);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(140, 238);
            this.heightBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(132, 22);
            this.heightBox.TabIndex = 4;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(140, 206);
            this.widthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(132, 22);
            this.widthBox.TabIndex = 5;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(25, 209);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(102, 17);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width (in tiles):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(25, 241);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(107, 17);
            this.heightLabel.TabIndex = 7;
            this.heightLabel.Text = "Height (in tiles):";
            // 
            // widthError
            // 
            this.widthError.ContainerControl = this;
            // 
            // heightError
            // 
            this.heightError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 394);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.createBox);
            this.Controls.Add(this.loadButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Level Editor";
            ((System.ComponentModel.ISupportInitialize)(this.createBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.PictureBox createBox;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.ErrorProvider widthError;
        private System.Windows.Forms.ErrorProvider heightError;
    }
}

