using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Form_Hell
{
    public partial class GameForm : Form
    {
        //Fields
        private Guess guessForm;
        private Form1 mainWindow;
        protected bool gameStart;
        protected double time;
        protected int timeLimit;
        protected int number;
        protected int guess;
        protected int low;
        protected int high;
        protected int color;
        protected int[] colors;



        //Field Properties
        //TimeLimit property
        public int TimeLimit
        {
            get
            {
                return timeLimit;
            }
            set
            {
                timeLimit = value;
            }
        }

        //Number property
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        //Low property
        public int Low
        {
            get
            {
                return low;
            }
            set
            {
                low = value;
            }
        }

        //High property
        public int High
        {
            get
            {
                return high;
            }
            set
            {
                high = value;
            }
        }



        public GameForm(Form1 main)
        {
            //Saving a reference to the main form
            this.mainWindow = main;

            //Creating a new Guess form, but not showing it yet
            guessForm = new Guess(this);

            //Creating an array of int's which will be used to change colors
            color = 0;
            colors = new int[5];
            colors[0] = 0;
            colors[1] = 1;
            colors[2] = 2;
            colors[3] = 3;
            colors[4] = 4;

            InitializeComponent();
        }

        //When the user closes the window, this prevents the actual "closing" of the form
        private void GameFormClosing(object sender, FormClosingEventArgs e)
        {
            //Stopping the Timer just in case it was still running
            timer.Stop();

            //Canceling the actual "closing" of the form
            e.Cancel = true;

            //Re-hiding the MessageBox and CloseButton
            messageBox.Visible = false;
            closeButton.Visible = false;

            //Enabling the StartButton
            startButton.Enabled = true;

            //Clearing all text boxes
            outBox.Text = "";

            // Instead, simply hide it
            this.Hide();
        }





        // --------------- Methods ---------------



        //Game Start Method
        public void Start(object sender, EventArgs e)
        {
            //Enabling the GuessBox and GuessButton
            guessButton.Enabled = true;

            //Creating a Random object
            Random rng = new Random();

            //Generating the number
            number = (int)rng.Next(low, high) + 1;

            //Starting the timer
            time = 0;
            gameStart = true;
            timer.Start();
            this.TimerTick(sender, e);
        }



        //Timer's Tick Event Handler
        private void TimerTick(object sender, EventArgs e)
        {
            //If the progress bar fills, the timer stops
            if (time >= timeLimit)
            {
                timer.Stop();
                gameStart = false;

                //Hiding the Guess form
                guessForm.Hide();

                //Revealing the MessageBox and CloseButton
                messageBox.Visible = true;
                closeButton.Visible = true;
                closeButton.Enabled = true;

                //Informing the user that they have failed
                messageBox.Text = "Too bad, you Failed!  The number was " + number.ToString();

                //Disabling the GuessButton and GuessBox
                guessButton.Enabled = false;

                //Re-enabling the start button to annoy users
                startButton.Enabled = true;
            }

            //Incrementing time by lower values to make the time displayed accurate
            time += 0.25;
        }



        //StartButton Click Method
        private void StartClick(object sender, EventArgs e)
        {
            //Starting the game and the timer
            this.Start(sender, e);
            this.TimerTick(sender, e);

            //Disabling the StartButton and CloseButton, and making the CloseButton and MessageBox invisible
            startButton.Enabled = false;
            closeButton.Enabled = false;
            closeButton.Visible = false;
            messageBox.Visible = false;

            this.ColorShift(sender, e);
        }



        //ColorShift method
        private void ColorShift(object sender, EventArgs e)
        {
            //Incrementing the value of color and then modulating it
            color++;
            color = color % 5;

            //Using a switch function to select which color to display
            switch(color)
            {
                //Displays red
                case 0:
                    this.BackColor = Color.Red;
                    break;

                //Displays orange
                case 1:
                    this.BackColor = Color.Orange;
                    break;

                //Displays yellow
                case 2:
                    this.BackColor = Color.Yellow;
                    break;

                //Displays green
                case 3:
                    this.BackColor = Color.Green;
                    break;

                //Displays blue
                case 4:
                    this.BackColor = Color.Blue;
                    break;
            }
        }



        //Guess Method
        private void GuessClick(object sender, EventArgs e)
        {
            guessForm.Low = low;
            guessForm.High = high;
            guessForm.NumLoad(sender, e);

            guessForm.Show();
        }



        //CloseButton Click Method
        private void CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }



        //Guess Method
        public void Guess(object sender, EventArgs e)
        {
            //Getting the value of guess from the GuessForm
            guess = guessForm.GuessNum;



            //If the guess is too high, the appropriate message is printed
            if (guess > number && guess >= low)
            {
                outBox.Text = "Lower";
            }

            //If the guess is too low, the appropriate message is printed
            else if (guess < number && guess <= high)
            {
                outBox.Text = "Higher";
            }

            //If the guess is correct, the appropriate message is printed and the timer is stopped
            else if (guess == number)
            {
                timer.Stop();

                //Clearing the outBox
                outBox.Text = "";

                //Revealing the MessageBox and CloseButton
                messageBox.Visible = true;
                closeButton.Visible = true;
                closeButton.Enabled = true;
                messageBox.Text = "Correct!";

                //Disabling the GuessButton and GuessBox
                guessButton.Enabled = false;

                //Re-enabling the start button to annoy users
                startButton.Enabled = true;
            }

            //Otherwise, and error will print in OutBox
            else
            {
                outBox.Text = "No";
            }
        }
    }
}
