namespace Level_Editor
{
    partial class Editor
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
            this.grassButton = new System.Windows.Forms.Button();
            this.dirtButton = new System.Windows.Forms.Button();
            this.skyButton = new System.Windows.Forms.Button();
            this.stoneButton = new System.Windows.Forms.Button();
            this.fireButton = new System.Windows.Forms.Button();
            this.nightButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.canvasBox = new System.Windows.Forms.GroupBox();
            this.currentBox = new System.Windows.Forms.GroupBox();
            this.selectionBox = new System.Windows.Forms.GroupBox();
            this.currentTile = new System.Windows.Forms.Button();
            this.currentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grassButton
            // 
            this.grassButton.BackColor = System.Drawing.Color.Green;
            this.grassButton.Location = new System.Drawing.Point(24, 30);
            this.grassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grassButton.Name = "grassButton";
            this.grassButton.Size = new System.Drawing.Size(75, 75);
            this.grassButton.TabIndex = 2;
            this.grassButton.UseVisualStyleBackColor = false;
            this.grassButton.Click += new System.EventHandler(this.GrassButtonClick);
            // 
            // dirtButton
            // 
            this.dirtButton.BackColor = System.Drawing.Color.Olive;
            this.dirtButton.Location = new System.Drawing.Point(24, 110);
            this.dirtButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dirtButton.Name = "dirtButton";
            this.dirtButton.Size = new System.Drawing.Size(75, 75);
            this.dirtButton.TabIndex = 3;
            this.dirtButton.UseVisualStyleBackColor = false;
            this.dirtButton.Click += new System.EventHandler(this.DirtButtonClick);
            // 
            // skyButton
            // 
            this.skyButton.BackColor = System.Drawing.Color.Aqua;
            this.skyButton.Location = new System.Drawing.Point(24, 191);
            this.skyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skyButton.Name = "skyButton";
            this.skyButton.Size = new System.Drawing.Size(75, 75);
            this.skyButton.TabIndex = 4;
            this.skyButton.UseVisualStyleBackColor = false;
            this.skyButton.Click += new System.EventHandler(this.SkyButtonClick);
            // 
            // stoneButton
            // 
            this.stoneButton.BackColor = System.Drawing.Color.Gray;
            this.stoneButton.Location = new System.Drawing.Point(105, 30);
            this.stoneButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stoneButton.Name = "stoneButton";
            this.stoneButton.Size = new System.Drawing.Size(75, 75);
            this.stoneButton.TabIndex = 5;
            this.stoneButton.UseVisualStyleBackColor = false;
            this.stoneButton.Click += new System.EventHandler(this.StoneButtonClick);
            // 
            // fireButton
            // 
            this.fireButton.BackColor = System.Drawing.Color.Red;
            this.fireButton.Location = new System.Drawing.Point(105, 110);
            this.fireButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(75, 75);
            this.fireButton.TabIndex = 6;
            this.fireButton.UseVisualStyleBackColor = false;
            this.fireButton.Click += new System.EventHandler(this.FireButtonClick);
            // 
            // nightButton
            // 
            this.nightButton.BackColor = System.Drawing.Color.Black;
            this.nightButton.Location = new System.Drawing.Point(105, 191);
            this.nightButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nightButton.Name = "nightButton";
            this.nightButton.Size = new System.Drawing.Size(75, 75);
            this.nightButton.TabIndex = 7;
            this.nightButton.UseVisualStyleBackColor = false;
            this.nightButton.Click += new System.EventHandler(this.NightButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(24, 497);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(156, 57);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(24, 560);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(156, 57);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Load File";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // canvasBox
            // 
            this.canvasBox.Location = new System.Drawing.Point(200, 10);
            this.canvasBox.Name = "canvasBox";
            this.canvasBox.Size = new System.Drawing.Size(540, 540);
            this.canvasBox.TabIndex = 13;
            this.canvasBox.TabStop = false;
            this.canvasBox.Text = "Map";
            // 
            // currentBox
            // 
            this.currentBox.Controls.Add(this.currentTile);
            this.currentBox.Location = new System.Drawing.Point(10, 300);
            this.currentBox.Name = "currentBox";
            this.currentBox.Size = new System.Drawing.Size(180, 180);
            this.currentBox.TabIndex = 14;
            this.currentBox.TabStop = false;
            this.currentBox.Text = "Current Tile";
            // 
            // selectionBox
            // 
            this.selectionBox.Location = new System.Drawing.Point(10, 10);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(180, 270);
            this.selectionBox.TabIndex = 15;
            this.selectionBox.TabStop = false;
            this.selectionBox.Text = "Tile Selection";
            // 
            // currentTile
            // 
            this.currentTile.Enabled = false;
            this.currentTile.Location = new System.Drawing.Point(30, 30);
            this.currentTile.Name = "currentTile";
            this.currentTile.Size = new System.Drawing.Size(120, 120);
            this.currentTile.TabIndex = 16;
            this.currentTile.UseVisualStyleBackColor = true;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 633);
            this.Controls.Add(this.canvasBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nightButton);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.stoneButton);
            this.Controls.Add(this.skyButton);
            this.Controls.Add(this.dirtButton);
            this.Controls.Add(this.grassButton);
            this.Controls.Add(this.currentBox);
            this.Controls.Add(this.selectionBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Editor";
            this.Text = "Level Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnsavedClose);
            this.currentBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button grassButton;
        private System.Windows.Forms.Button dirtButton;
        private System.Windows.Forms.Button skyButton;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button fireButton;
        private System.Windows.Forms.Button nightButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.GroupBox canvasBox;
        private System.Windows.Forms.GroupBox currentBox;
        private System.Windows.Forms.GroupBox selectionBox;
        private System.Windows.Forms.Button currentTile;
    }
}