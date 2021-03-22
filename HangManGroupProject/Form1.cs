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
    }
}
