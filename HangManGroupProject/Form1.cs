//3/21/21 Started By tristyn naeole
//ISDS309 Team:Erik Klingenberg,Tristyn Naeole,Steven Bao,Reet paul gill

//MAKE A USERLOGIN !!!!!!!!!!!!!!!!!!! 2D arrary

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
        
        string selectedword,userGuess, tempword;
        const int LIVES = 5;
        int usedLIVES = 0;
        int length;
        bool correctGuess;
        
        //reads from the text and shoves everything in the txt into an arrary
        //words_alpha is the txt file with the words it is located in the main folder. same location as the program.cs file.
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\trist\source\repos\HangManGroupProject\HangManGroupProject\words_alpha.txt");

        public void IncrementHangman()
        {
            usedLIVES++;
            switch(usedLIVES)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile("Images/Hangman1.bmp");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("Images/Hangman2.bmp");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("Images/Hangman3.bmp");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("Images/Hangman4.bmp");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("Images/Hangman5.bmp");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile("Images/Hangman6.bmp");
                    break;
                
            }

        }
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
            
            
            for(int i = 0; i <selectedword.Length;i++)
            {
                label1.Text += "*";
            }
            
        }
        
        public void Game()
        {
            for (int i = 0; i < selectedword.Length; i++)
            {
                if(userGuess ==selectedword.Substring(i,1))
                {
                    tempword += selectedword.Substring(i, 1);
                }
                else
                {
                    tempword += label1.Text.Substring(i, 1);
                    IncrementHangman();
                }
            }
            label1.Text = tempword;
            tempword = "";

        }
        public Form1()
        {
            InitializeComponent();
            selectWord();
            
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
            userGuess = "a";
            Game();
        }
        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonB.Enabled = false;// this grays out button
            this.Controls.Add(buttonB);
            userGuess = "b";
            Game();

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Enabled = false;// this grays out button
            this.Controls.Add(buttonC);
            userGuess = "c";
            Game();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonD.Enabled = false;// this grays out button
            this.Controls.Add(buttonD);
            userGuess = "d";
            Game();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            buttonE.Enabled = false;// this grays out button
            this.Controls.Add(buttonE);
            userGuess = "e";
            Game();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            buttonF.Enabled = false;// this grays out button
            this.Controls.Add(buttonF);
            userGuess = "f";
            Game();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            buttonG.Enabled = false;// this grays out button
            this.Controls.Add(buttonG);
            userGuess = "g";
            Game();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            buttonH.Enabled = false;// this grays out button
            this.Controls.Add(buttonH);
            userGuess = "h";
            Game();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            buttonI.Enabled = false;// this grays out button
            this.Controls.Add(buttonI);
            userGuess = "i";
            Game();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            buttonJ.Enabled = false;// this grays out button
            this.Controls.Add(buttonJ);
            userGuess = "j";
            Game();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            buttonK.Enabled = false;// this grays out button
            this.Controls.Add(buttonK);
            userGuess = "k";
            Game();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.Enabled = false;// this grays out button
            this.Controls.Add(buttonL);
            userGuess = "l";
            Game();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            buttonM.Enabled = false;// this grays out button
            this.Controls.Add(buttonM);
            userGuess = "m";
            Game();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonN.Enabled = false;// this grays out button
            this.Controls.Add(buttonN);
            userGuess = "n";
            Game();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Enabled = false;// this grays out button
            this.Controls.Add(buttonO);
            userGuess = "o";
            Game();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            buttonP.Enabled = false;// this grays out button
            this.Controls.Add(buttonP);
            userGuess = "p";
            Game();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            buttonQ.Enabled = false;// this grays out button
            this.Controls.Add(buttonQ);
            userGuess = "q";
            Game();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonR.Enabled = false;// this grays out button
            this.Controls.Add(buttonR);
            userGuess = "r";
            Game();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            buttonS.Enabled = false;// this grays out button
            this.Controls.Add(buttonS);
            userGuess = "s";
            Game();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            buttonT.Enabled = false;// this grays out button
            this.Controls.Add(buttonT);
            userGuess = "t";
            Game();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            buttonU.Enabled = false;// this grays out button
            this.Controls.Add(buttonU);
            userGuess = "u";
            Game();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            buttonV.Enabled = false;// this grays out button
            this.Controls.Add(buttonV);
            userGuess = "v";
            Game();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            buttonW.Enabled = false;// this grays out button
            this.Controls.Add(buttonW);
            userGuess = "w";
            Game();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Enabled = false;// this grays out button
            this.Controls.Add(buttonX);
            userGuess = "x";
            Game();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            buttonY.Enabled = false;// this grays out button
            this.Controls.Add(buttonY);
            userGuess = "y";
            Game();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonZ.Enabled = false;// this grays out button
            this.Controls.Add(buttonZ);
            userGuess = "z";
            Game();
        }
    }
}
