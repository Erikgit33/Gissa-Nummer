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
        int number;
        int guesses = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string str = number.ToString();
            textBox1.Text = str;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(textBox1.Text);
           guesses = guesses + 1;
            if (guess == number)
            {
                MessageBox.Show("Du gissade rätt efter " + guesses.ToString() + " Försök!");
                number = rng.Next(1, 21);
                guesses = 0;
            }
            else if (guess > number)
            {
                MessageBox.Show("Du gissade för högt!");
            }
            else 
            {
                MessageBox.Show("Du gissade för lågt!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            number = rng.Next(1, 21);
        }
    }
}
