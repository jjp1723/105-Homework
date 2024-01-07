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
    public partial class Guess : Form
    {
        //Fields
        private GameForm gameForm;
        protected int low;
        protected int high;
        protected int guess;



        //Field Properties
        //Low Propterty
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

        //High Property
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

        //Guess Property
        public int GuessNum
        {
            get
            {
                return guess;
            }
            set
            {
                guess = value;
            }
        }



        //Loading the Form
        public Guess(GameForm game)
        {
            //Saving a reference to the GameForm
            this.gameForm = game;

            InitializeComponent();
        }

        //When the user closes the window, this prevents the actual "closing" of the form
        private void GameFormClosing(object sender, FormClosingEventArgs e)
        {
            //Canceling the actual "closing" of the form
            e.Cancel = true;

            //Instead, simply hiding it
            this.Hide();

            //Disabling the guess button
            guessButton.Enabled = false;

            //Unchecking the checkbox
            guessCheck.Checked = false;
        }



        //Methods
        //Load Method for the guessBox
        public void NumLoad(object sender, EventArgs e)
        {
            //Loading all possible guesses into a list
            for (int num = low; num <= high; num++)
            {
                guessBox.Items.Add(num);
            }

            //Disabling the guess button
            guessButton.Enabled = false;
        }

        //Guess Method
        private void GuessClick(object sender, EventArgs e)
        {
            //If the input is an int, then it will be parsed into the "low" field
            if (int.TryParse(guessBox.Text, out guess))
            {
                guess = int.Parse(guessBox.Text);
            }

            gameForm.Guess(sender, e);

            this.Close();
        }

        //GuessButtonKey method
        private void GuessButtonKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                this.GuessClick(sender, e);
            }
        }

        //GuessCheck checkbox method
        private void GuessCheck(object sender, EventArgs e)
        {
            guessButton.Enabled = true;
        }
    }
}
