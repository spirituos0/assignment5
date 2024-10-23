using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentVika5_1
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int numberOfGuesses;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 101);
            numberOfGuesses = 0;
            lblResult.Text = "";
            lblAttempts.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int userGuess;
            if (int.TryParse(txtGuess.Text, out userGuess))
            {
                numberOfGuesses++;
                if (userGuess > randomNumber)
                {
                    lblResult.Text = "Too high, try again.";
                }
                else if (userGuess < randomNumber)
                {
                    lblResult.Text = "Too low, try again.";
                }
                else
                {
                    lblResult.Text = "Congratulations! You guessed the number!";
                    lblAttempts.Text = $"It took you {numberOfGuesses} attempts.";
                    MessageBox.Show($"Congratulations! You guessed the number! It took you {numberOfGuesses} attempts. Try again!");
                    InitializeGame();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
