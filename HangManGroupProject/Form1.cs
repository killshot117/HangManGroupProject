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

namespace HangManGroupProject
{
    public partial class Form1 : Form
    {
        string selectedword;
        int lives = 5;
        int length;
        //example words. Words need to be read from a file.
        string[] words = 
        {
            "Apple",
            "Chair",
            "Tree",
            "School",
        };
        public void selectWord()
        {
            int min = 1;
            int max = 4;
            Random r = new Random();
            int randomNumber;
            randomNumber = r.Next(min, max);
            length = selectedword.Length;
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
