//3/21/21 Started By tristyn naeole
//ISDS309 Team:Erik Klingenberg,Tristyn Naeole,Steven Bao,Reet paul gill
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//words_alpha.txt is from https://github.com/dwyl/english-words.git

namespace HangManGroupProject
{
    public partial class Form1 : Form
    {
        string selectedword;
        const int LIVES = 5;
        int usedLIVES = 0;
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
            int Len = 0;
            
            
            selectedword = lines[randomNumber];//uses the random number and picks a word.
            length = selectedword.Length;//looks at the choesen word and figures out how long it is.
            
            while(Len<length)
            {
                label1.Text += "_ ";
                Len++;
            }
        }
        
        public void Game()
        {
            if(usedLIVES<LIVES)
            {

            }
        }
        public Form1()
        {
            InitializeComponent();
            selectWord();
            Game();
        }

        private void pictureBox1_Click(object sender, EventArgs e)//ignore
        {

        }

        private void label1_Click(object sender, EventArgs e)//ignore
        {

        }

        private void Form1_Load(object sender, EventArgs e)//ignore
        {

        }
        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;// this grays out button
            this.Controls.Add(buttonA);
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonB.Enabled = false;// this grays out button
            this.Controls.Add(buttonB);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Enabled = false;// this grays out button
            this.Controls.Add(buttonC);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonD.Enabled = false;// this grays out button
            this.Controls.Add(buttonD);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            buttonE.Enabled = false;// this grays out button
            this.Controls.Add(buttonE);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            buttonF.Enabled = false;// this grays out button
            this.Controls.Add(buttonF);
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            buttonG.Enabled = false;// this grays out button
            this.Controls.Add(buttonG);
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            buttonH.Enabled = false;// this grays out button
            this.Controls.Add(buttonH);
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            buttonI.Enabled = false;// this grays out button
            this.Controls.Add(buttonI);
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            buttonJ.Enabled = false;// this grays out button
            this.Controls.Add(buttonJ);
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            buttonK.Enabled = false;// this grays out button
            this.Controls.Add(buttonK);
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.Enabled = false;// this grays out button
            this.Controls.Add(buttonL);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            buttonM.Enabled = false;// this grays out button
            this.Controls.Add(buttonM);
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonN.Enabled = false;// this grays out button
            this.Controls.Add(buttonN);
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Enabled = false;// this grays out button
            this.Controls.Add(buttonO);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            buttonP.Enabled = false;// this grays out button
            this.Controls.Add(buttonP);
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            buttonQ.Enabled = false;// this grays out button
            this.Controls.Add(buttonQ);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonR.Enabled = false;// this grays out button
            this.Controls.Add(buttonR);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            buttonS.Enabled = false;// this grays out button
            this.Controls.Add(buttonS);
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            buttonT.Enabled = false;// this grays out button
            this.Controls.Add(buttonT);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            buttonU.Enabled = false;// this grays out button
            this.Controls.Add(buttonU);
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            buttonV.Enabled = false;// this grays out button
            this.Controls.Add(buttonV);
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            buttonW.Enabled = false;// this grays out button
            this.Controls.Add(buttonW);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Enabled = false;// this grays out button
            this.Controls.Add(buttonX);
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            buttonY.Enabled = false;// this grays out button
            this.Controls.Add(buttonY);
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonZ.Enabled = false;// this grays out button
            this.Controls.Add(buttonZ);
        }
    }
}
