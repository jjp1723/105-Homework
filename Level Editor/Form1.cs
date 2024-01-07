using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level_Editor
{
    public partial class Form1 : Form
    {
        //Fields
        private Editor editor;
        protected int width;
        protected int height;



        //Field Properties
        //Width Property
        public int TileWidth
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        //Height Property
        public int TileHeight
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }



        //Initializer
        public Form1()
        {
            InitializeComponent();

            //Initializing fields
            width = 0;
            height = 0;

            //Dispalying the width and height
            widthBox.Text = width.ToString();
            heightBox.Text = height.ToString();
        }





        // --------------- Methods ---------------



        //LoadMap Method
        private void LoadMap(object sender, EventArgs e)
        {
            //Creating an OpenFileDialog object and having the user select a file
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open a level file";
            openFile.Filter = "Level Files|*.level";
            DialogResult result = openFile.ShowDialog();

            //If the user does select a level file, the name of the file is passed to the editor and the editor is opened
                //The editor then performs the actual opening of the file
            if(result == DialogResult.OK)
            {
                //Saving the file name
                string levelFileName = openFile.FileName;

                //Creating a new editor window
                editor = new Editor(this);

                //Passing the file name to the editor and calling the edito's LoadAFile method
                editor.LoadAFile(levelFileName);

                //Revealing the editor window
                editor.Show();
            }
        }



        //CreateMap Method
        private void CreateMap(object sender, EventArgs e)
        {
            //Creating a new editor window
            editor = new Editor(this);

            //Setting the values of the width and height fields of the editor
            editor.CanvasWidth = width;
            editor.CanvasHeight = height;

            //Calls the editor's generateTile method to create the map
            editor.TileGenerate();

            //Setting the width and height of the editor window
            editor.Width = 540 / height * width + 250;
            editor.Height = 650;


            //Revealing the editor window
            editor.Show();
        }



        //CreateButtonClick Method
        private void CreateButtonClick(object sender, EventArgs e)
        {
            //Creating booleans that will be used to determine whether the user has entered acceptable values for the width and height
            bool acceptableWidth = false;
            bool acceptableHeight = false;
            string widthErrorMessage = "";
            string heightErrorMessage = "";

            //Checking for possible errors with the width before proceeding
                //first by checking whether it is a number, then checking whether it is too low or too high, and generating error messages accordingly
            //If the input is not an integer
            if (!int.TryParse(widthBox.Text, out width))
            {
                widthBox.Focus();
                widthError.SetError(widthBox, "Not a number");
                widthErrorMessage = "- Invalid width.  Must be an integer.\n";
            }
            //The input is too low
            else if(int.Parse(widthBox.Text) < 10)
            {
                widthBox.Focus();
                widthError.SetError(widthBox, "Too low");
                widthErrorMessage = "- Width is too low.  Minimum is 10.\n";
            }
            //The input is too high
            else if(int.Parse(widthBox.Text) > 30)
            {
                widthBox.Focus();
                widthError.SetError(widthBox, "Too high");
                widthErrorMessage = "- Width is too high.  Maximum is 30\n";
            }
            //The input is accpetable
            else
            {
                width = int.Parse(widthBox.Text);
                widthError.Clear();
                acceptableWidth = true;
                widthErrorMessage = "";
            }

            //Checking for possible errors with the height before proceeding
                //first by checking whether it is a number, then checking whether it is too low or too high, and generating error messages accordingly
            //If the input is not an integer
            if (!int.TryParse(heightBox.Text, out height))
            {
                heightBox.Focus();
                heightError.SetError(heightBox, "Not a number");
                heightErrorMessage = "- Invalid height.  Must be an integer\n";
            }
            //If the input is too low
            else if (int.Parse(heightBox.Text) < 10)
            {
                heightBox.Focus();
                heightError.SetError(heightBox, "Too low");
                heightErrorMessage = "- Height is too low.  Minumum is 10\n";
            }
            //If the input is too high
            else if (int.Parse(heightBox.Text) > 30)
            {
                heightBox.Focus();
                heightError.SetError(heightBox, "Too high");
                heightErrorMessage = "- Height is too high.  Maximum is 30\n";
            }
            //The input is acceptable
            else
            {
                height = int.Parse(heightBox.Text);
                heightError.Clear();
                acceptableHeight = true;
                widthErrorMessage = "";
            }



            //If there are no errors with the input width and height, the editor is opened
            if(acceptableWidth && acceptableHeight)
            {
                this.CreateMap(sender, e);
            }
            //Otherwise, an error message is shown
            else
            {
                MessageBox.Show("Errors:\n" + widthErrorMessage + heightErrorMessage, "Error Creating Map", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
