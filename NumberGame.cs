// (Guess the Number Game) NumberGame.cs
// TMCC VeryAble 2018
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class NumberPanel : Form
    {
        // Skeleton variables
        string temp = null;
        string guess = null;
        string number = null;
        int counter = 0;
       
        // Where it all began... 
        public NumberPanel()
        {
            InitializeComponent(); // Start your engins... 
            lblIndicator.Text = "Hello"; // greetings Earthing
        }

        // Guess textbox
        private void TxtbGuess_TextChanged(object sender, EventArgs e)
        {
            guess = txtbGuess.Text;
        }

        // Start button
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random numbero = new Random(); // Random number generator
            number = numbero.Next(1, 1000).ToString(); // Placing random number into string
            txtbGuess.BackColor = Color.White; // Default background
            txtbGuess.ForeColor = Color.Black; // Defualt text color
            txtbGuess.Enabled = true; // Allow guesses
            lblIndicator.Text = "Good Luck!"; // Lucky Charm
            counter = 0; // Reset guess counter
            lblCounter.Text = $"Guess #{counter + 1}"; // Display guess counter
            txtbGuess.Text = ""; // Reset guesses displayed
        }

        // Enter button
        private void btnSend_Click(object sender, EventArgs e)
        {
            ++counter; // Increase guess count 
            lblCounter.Text = $"Guess #{counter}"; // Display guess count

            guess = txtbGuess.Text; // Place guess into variable

            if (counter == 1) // If first guess
            {
                temp = guess; // Place first guess into temp variable
            }

            lblIndicator.Text = number; // Developer mode only

            try
            {
                if (int.Parse(guess) == int.Parse(number)) // Guess correctly
                {
                    txtbGuess.BackColor = Color.Green; // Change background consistantly rather than changing Form's background
                    txtbGuess.ForeColor = Color.Yellow; // Change text color
                    lblIndicator.Text = "You Win!"; // indication of victory
                    txtbGuess.Enabled = false; // Disable textbox
                    txtbGuess.Text = ""; // Clear input
                }
                else if (counter == 1) // if first guess
                {
                    if (int.Parse(guess) > int.Parse(number)) // too high
                    {
                        txtbGuess.ForeColor = Color.Red; // Change color to indictae too high
                        lblIndicator.Text = "High!"; // Yell at them
                    }
                    else if (int.Parse(guess) < int.Parse(number)) // Too low
                    {
                        txtbGuess.ForeColor = Color.Blue; // Change color to indicate too low
                        lblIndicator.Text = "Low!"; // Yell at them
                    }
                }
                else if (counter > 1) // If not the first game
                {
                    if (int.Parse(guess) > int.Parse(number) && int.Parse(guess) > int.Parse(temp)) // Too high and Too high
                    {
                        txtbGuess.BackColor = Color.Blue; // Change to indicate colder
                        txtbGuess.ForeColor = Color.White; // Change text color
                        lblIndicator.Text = "Too High!"; // Yell at them
                        temp = guess; // Place last guess into temp
                    }
                    else if (int.Parse(guess) < int.Parse(number) && int.Parse(guess) < int.Parse(temp)) // Too low and Too low
                    {
                        txtbGuess.BackColor = Color.Blue; // Change to indicate colder
                        txtbGuess.ForeColor = Color.White; // Change text color
                        lblIndicator.Text = "Too Low!"; // Yell at them
                        temp = guess; // Place last guess into temp
                    }
                    else if (int.Parse(guess) < int.Parse(number) && int.Parse(guess) > int.Parse(temp)) // Too low and Closer
                    {
                        txtbGuess.BackColor = Color.Red; // Change to indicate warmer
                        txtbGuess.ForeColor = Color.Black; // Change text color
                        lblIndicator.Text = "Too Low!"; // Yell at them
                        temp = guess; // Place last guess into temp
                    }
                    else if (int.Parse(guess) > int.Parse(number) && int.Parse(guess) < int.Parse(temp)) // Too high and Closer
                    {
                        txtbGuess.BackColor = Color.Red; // Change to indicate warmer
                        txtbGuess.ForeColor = Color.Black; // Change text color
                        lblIndicator.Text = "Too High!"; // Yell at them
                        temp = guess; // Place last guess into temp
                    }
                }
            }
            catch (FormatException fe) // When emptying out last guess
            {
                // Do nothing but still run

                //MessageBox.Show($"{fe}"); // Developer mode only

            }
            catch (Exception ex) // For everything else
            {
                MessageBox.Show($"Please try again!");

                //MessageBox.Show($"{ex}"); // Developer mode only
            }
        }
    }
// thanks for looking
}
