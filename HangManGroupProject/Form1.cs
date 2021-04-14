//3/21/21 Started By tristyn naeole
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//everything here is temp

namespace HangManGroupProject
{
    public partial class Form1 : Form
    {
        string selectedword;
        int lives = 5;
        int length;
        //reads from the text and shoves everything in the txt into an arrary
        //words_alpha is the txt file with the words it is located in the main folder. same location as the program.cs file.
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\trist\source\repos\HangManGroupProject\HangManGroupProject\words_alpha.txt");

        
        public void selectWord()
        {
            //random num gen
            int min = 500;
            int max = 90000;
            Random r = new Random();
            int randomNumber;
            randomNumber = r.Next(min, max);

            selectedword = lines[randomNumber];//uses the random number and picks a word.
            length = selectedword.Length;//looks at the choesen word and figures out how long it is.
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;// this grays out button
            this.Controls.Add(buttonA);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
