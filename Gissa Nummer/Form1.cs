using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gissa_Nummer
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        int number; //One random variable which range is specified later, and two integrals. Number represents the value 
        int guesses = 0; //that is randomized, and the other is for counting your guesses.
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string str = number.ToString();
            textBox1.Text = str;
            //You can cheat by pressing the label, the ranomized number will appear in the textbox.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(textBox1.Text);
            guesses = guesses + 1;
            if (guess == number)
            {
                MessageBox.Show("You guessed correctly after " + guesses.ToString() + " Guesses!");
                number = rng.Next(1, 21);
                guesses = 0;
            }
            else if (guess > number)
            {
                MessageBox.Show("You guessed to low!");
            }
            else 
            {
                MessageBox.Show("You guessed to high!"); 
            }
            //As you press the button that says "Guess", you guess is stored in the variable "guess". Your guess count also increases
            //by one. Then, if you guessed correctly, you will be greeted with a box that says that you guessed right and after how many tries.
            //If you guess too low or high, you will be greeted by a corresponing box.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            number = rng.Next(1, 21); //As the project loads, the number is set to a value between 1 and 20. 
        }
    }
}
