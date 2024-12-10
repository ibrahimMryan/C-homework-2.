using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guss_the_number
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int previousDifference;
        private Random random = new Random();
        private int attempts;
        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }
        private void StartNewGame()
        {
            randomNumber = random.Next(1, 1001);
            previousDifference = int.MaxValue;
            attempts = 0; 

            this.BackColor = DefaultBackColor;
            textBox_guess.Enabled = true;
            textBox_guess.Clear();
            label2.Text = "Guess a number between 1 and 1000!";
            textBox_guess.Focus();
        }


        private void textBox_guess_TextChanged(object sender, EventArgs e)
        {



        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_newGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void textBox_guess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 

                if (int.TryParse(textBox_guess.Text, out int userGuess) && userGuess >= 1 && userGuess <= 1000)
                {
                    attempts++; 
                    int currentDifference = Math.Abs(randomNumber - userGuess);

                    if (userGuess == randomNumber)
                    {
                        this.BackColor = Color.Green;
                        label2.Text = $"Correct! It took you {attempts} attempts.";
                        textBox_guess.Enabled = false; 
                    }
                    else
                    {
                        label2.Text = userGuess > randomNumber ? "Too High" : "Too Low";

                        this.BackColor = currentDifference < previousDifference ? Color.Red : Color.Blue;
                        previousDifference = currentDifference;
                    }

                    textBox_guess.Clear(); 
                }
                else
                {
                    MessageBox.Show("Please enter a valid number between 1 and 1000.", "Invalid Input");
                    textBox_guess.Clear();
                }
            }
        } 

    }
}


    


