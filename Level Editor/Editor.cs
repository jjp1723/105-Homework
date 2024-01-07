using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Level_Editor
{
    public partial class Editor : Form
    {
        //Fields
        protected Form1 mainwindow;
        protected int canvasWidth;
        protected int canvasHeight;
        protected System.Drawing.Color color;
        protected List<PictureBox> tileList;
        protected string title;
        protected bool saved;



        //Field Properties
        //CanvasWidth Property
        public int CanvasWidth
        {
            get
            {
                return canvasWidth;
            }
            set
            {
                canvasWidth = value;
            }
        }

        //CanvasHeight Property
        public int CanvasHeight
        {
            get
            {
                return canvasHeight;
            }
            set
            {
                canvasHeight = value;
            }
        }



        //Innitializer
        public Editor(Form1 main)
        {
            //Saving a reference to the main form
            this.mainwindow = main;

            InitializeComponent();
        }





        // --------------- Methods ---------------



        //UnsavedClose Method
        private void UnsavedClose(object sender, FormClosingEventArgs e)
        {
            //Only proceeds if the file hasn't been saved
            if(!saved)
            {
                //Displaying a message asking the user if they want to save the file
                DialogResult result = MessageBox.Show("There are unsaved changes.  Are you sure you want to quit?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                //If the user selects no, the form remains open, otherwise it is closed without saving changes
                if(result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }


        //SaveButtonClick Method
        private void SaveButtonClick(object sender, EventArgs e)
        {
            //Creating a SaveFileDialog object and having the user name and save the file to a location
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save a level file";
            saveFile.Filter = "Level Files|*.level";
            DialogResult result = saveFile.ShowDialog();

            //If the user does save a file, the name of the file is passed to the SaveAFile method
            if(result == DialogResult.OK)
            {
                this.SaveAFile(saveFile.FileName);
            }
        }



        //SaveAFile Method
        public void SaveAFile(string fileName)
        {
            //Creating file stream
            FileStream outstream = File.OpenWrite(fileName);

            //Creating stream writer
            StreamWriter output = new StreamWriter(outstream);

            //Writing the data for the width and height to the stream object
            output.WriteLine(canvasWidth);
            output.WriteLine(canvasHeight);

            //Writing data into stream object
            foreach (PictureBox tile in tileList)
            {
                output.WriteLine(tile.BackColor.ToArgb());
            }

            //Closing the writer
            output.Close();

            //Changing the title of the editor
            string[] name = fileName.Split('\\');
            int nameLength = name.Length;
            title = name[nameLength - 1];
            this.Text = "Level Editor - " + title;

            //Displaying a message telling the user the file was saved
            MessageBox.Show("File saved successfully!", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            saved = true;
        }



        //LoadButtonClick Method
        private void LoadButtonClick(object sender, EventArgs e)
        {
            //Creating an OpenFileDialog object and having the user select a file
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open a level file";
            openFile.Filter = "Level Files|*.level";
            DialogResult result = openFile.ShowDialog();

            //If the user does select a level file, the name of the file is passed to the LoadAFile method
            if (result == DialogResult.OK)
            {
                this.LoadAFile(openFile.FileName);
            }
        }



        //LoadAFile Method
        public void LoadAFile(string fileName)
        {
            //Creating variables that represent the file before try/catch
            FileStream inStream = null;
            StreamReader input = null;

            //Create file stream
            inStream = File.OpenRead(fileName);

            //Creating stream reader
            input = new StreamReader(inStream);

            //Implementing try/catch for any potential errors
            try
            {
                //Removing all pictureboxes from the form
                    //The while loop ensures that nothing is skipped directly after removing a picturebox
                bool removed = true;
                while(removed)
                {
                    removed = false;
                    foreach (Control control in this.Controls)
                    {
                        if (control.GetType() == typeof(PictureBox))
                        {
                            this.Controls.Remove(control);
                            removed = true;
                        }
                    }
                }

                //Reading the width and height from the file
                canvasWidth = int.Parse(input.ReadLine());
                canvasHeight = int.Parse(input.ReadLine());

                //Setting the width and height of the editor window
                this.Width = 540 / canvasHeight * canvasWidth + 250;
                this.Height = 650;

                //Innitializing tileList
                tileList = new List<PictureBox>();

                //Calculating the dimensions of the tiles based off the provided dimensions of the canvas
                int tileSide = 540 / canvasHeight;

                //Setting the size of the CanvasBox
                canvasBox.Size = new Size(canvasWidth * tileSide + 30, canvasHeight * tileSide + 45);

                //Creating nested loops that adds PictureBoxes buttons in a grid
                for (int row = 0; row < canvasHeight; row++)
                {
                    for (int collumn = 0; collumn < canvasWidth; collumn++)
                    {
                        //Setting x and y coordiantes for the button using "row" and "collumn" variables
                        int x = collumn * tileSide + 170;
                        int y = row * tileSide + 35;

                        //Create a Picturebox tile to interact with
                        PictureBox tile = new PictureBox();
                        tile.Size = new Size(tileSide, tileSide);
                        tile.Location = new Point(x, y);
                        tile.BackColor = Color.FromArgb(int.Parse(input.ReadLine()));
                        tile.BringToFront();

                        //Adding the tile to the CanvasBox
                        canvasBox.Controls.Add(tile);

                        //Add the TileClick functionality to the tile
                        tile.Click += TileClick;

                        //Add the tile to the form's list of Controls
                        this.Controls.Add(tile);

                        //Add the tile to tileList
                        tileList.Add(tile);
                    }
                }

                //Changing the title of the editor
                string[] name = fileName.Split('\\');
                int nameLength = name.Length;
                title = name[nameLength - 1];
                this.Text = "Level Editor - " + title;

                //Displaying a message telling the user the file was loaded
                MessageBox.Show("File loaded successfully!", "File Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                saved = true;
            }
            catch
            {
                //Displaying a message telling the user there was an error loading the file
                MessageBox.Show("There was an issue loading the file, some data may be missing.", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Closing the reader/stream
            finally
            {
                if (input != null)
                {
                    input.Close();
                }

                //Sending the CanvasBox to the back
                canvasBox.SendToBack();
            }
        }


        //TileGenerate Method
        public void TileGenerate()
        {
            //Innitializing tileList
            tileList = new List<PictureBox>();

            //Calculating the dimensions of the tiles based off the provided dimensions of the canvas
            int tileSide = 540 / canvasHeight;

            //Setting the size of the CanvasBox
            canvasBox.Size = new Size(canvasWidth * tileSide + 30, canvasHeight * tileSide + 30);

            //Creating nested loops that adds PictureBoxes in a grid
            for (int row = 0; row < canvasHeight; row++)
            {
                for (int collumn = 0; collumn < canvasWidth; collumn++)
                {
                    //Setting x and y coordiantes for the button using "row" and "collumn" variables
                    int x = collumn * tileSide + 170;
                    int y = row * tileSide + 35;

                    //Create a button to interact with
                    PictureBox tile = new PictureBox();
                    tile.Size = new Size(tileSide, tileSide);
                    tile.Location = new Point(x, y);

                    //Adding the tile to the CanvasBox
                    canvasBox.Controls.Add(tile);

                    //Add the TileClick functionality to the tile
                    tile.Click += TileClick;

                    //Add the tile to the form's list of Controls
                    this.Controls.Add(tile);

                    //Add the tile to tileList
                    tileList.Add(tile);
                }
            }

            //Sending the CanvasBox to the back
            canvasBox.SendToBack();
        }



        //GrassButtonClick Method
        private void GrassButtonClick(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Green;
            currentTile.BackColor = color;
        }



        //StoneButtonClick Method
        private void StoneButtonClick(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Gray;
            currentTile.BackColor = color;
        }



        //DirtButtonClick Method
        private void DirtButtonClick(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Olive;
            currentTile.BackColor = color;
        }



        //FireButtonClick Method
        private void FireButtonClick(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Red;
            currentTile.BackColor = color;
        }



        //SkyButtonClick Method
        private void SkyButtonClick(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Aqua;
            currentTile.BackColor = color;
        }



        //NightButtonClick Method
        private void NightButtonClick(object sender, EventArgs e)
        {
            color = System.Drawing.Color.Black;
            currentTile.BackColor = color;
        }



        //TileClick Method
        private void TileClick(object sender, EventArgs e)
        {
            if(sender is PictureBox)
            {
                PictureBox tile = (PictureBox)sender;
                tile.BackColor = color;

                //Adding an Asterisk to the title of the editor
                this.Text = "Level Editor -" + title + "*";
                saved = false;
            }
        }
    }
}
