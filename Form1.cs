using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Morpion
{
    public partial class Accueil : System.Windows.Forms.Form
    {
       
        public Accueil()
        {
            
            InitializeComponent();
            music2 = new SoundPlayer("fond.wav");
            music2.PlayLooping();
            
        }
        bool joueur;
        private SoundPlayer music2;
        int victoirejoueur1 = 1;
        int victoirejoueur2 = 1;
       

        
        private void cmdQuite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdCase1_Click(object sender, EventArgs e)
        {
            
            if (joueur == true)
            {
                cmdCase1.BackColor= Color.Red;
                cmdCase1.Text = "X";
                joueur = false;
            }
            else
            {
                cmdCase1.BackColor = Color.Yellow;
                cmdCase1.Text = "O";
                joueur = true;
            }

            cmdCase1.Enabled = false;

            if (((cmdCase1.Text == cmdCase2.Text) && (cmdCase1.Text == cmdCase3.Text)) ||
            ((cmdCase1.Text == cmdCase4.Text) && (cmdCase1.Text == cmdCase7.Text)) ||
            ((cmdCase1.Text == cmdCase5.Text) && (cmdCase1.Text == cmdCase9.Text)))
            {
                if (joueur == true)
                {
                    vainqueur.Text = "Le joueur 1 à gagné !!!";
                    vainqueur.ForeColor = Color.Yellow;
                    vainqueur.BackColor = Color.Black;
                    score1.Text = "Joueur 1 = " + victoirejoueur1;
                    score1.ForeColor = Color.Yellow;
                    victoirejoueur1++;


                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                else if (joueur == false)
                {

                    vainqueur.Text = "Le joueur 2 à gagné !!!";
                    vainqueur.ForeColor = Color.Red;
                    vainqueur.BackColor = Color.Black;
                    score2.Text = "Joueur 2 = " + victoirejoueur2;
                    score2.ForeColor = Color.Red;
                    victoirejoueur2++;


                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }

            }

        }

        private void cmdCase2_Click(object sender, EventArgs e)
        {
            if (joueur == true)
            {
                cmdCase2.BackColor = Color.Red;
                cmdCase2.Text = "X";
                joueur = false;
            }
            else
            {
                cmdCase2.BackColor = Color.Yellow;
                cmdCase2.Text = "O";
                joueur = true;
            }
            cmdCase2.Enabled = false;

            if (((cmdCase2.Text == cmdCase1.Text) && (cmdCase2.Text == cmdCase3.Text)) ||
            ((cmdCase2.Text == cmdCase5.Text) && (cmdCase2.Text == cmdCase8.Text)))

            {
                if (joueur == true)
                {
                    vainqueur.Text = "Le joueur 1 à gagné !!!";
                    vainqueur.ForeColor = Color.Yellow;
                    vainqueur.BackColor = Color.Black;
                    score1.Text = "Joueur 1 = " + victoirejoueur1;
                    score1.ForeColor = Color.Yellow;
                    victoirejoueur1++;
               

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                else
                {

                    vainqueur.Text = "Le joueur 2 à gagné !!!";
                    vainqueur.ForeColor = Color.Red;
                    vainqueur.BackColor = Color.Black;
                    score2.Text = "Joueur 2 = " + victoirejoueur2;
                    score2.ForeColor = Color.Red;
                    victoirejoueur2++;
                 

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
            }
         
        }

        private void cmdCase3_Click(object sender, EventArgs e)
        {
            if (joueur == true)
            {
                cmdCase3.BackColor = Color.Red;
                cmdCase3.Text = "X";
                joueur = false;
            }
            else
            {
                cmdCase3.BackColor = Color.Yellow;
                cmdCase3.Text = "O";
                joueur = true;
            }
            cmdCase3.Enabled = false;

            if (((cmdCase3.Text == cmdCase1.Text) && (cmdCase3.Text == cmdCase2.Text)) ||
            ((cmdCase3.Text == cmdCase7.Text) && (cmdCase3.Text == cmdCase5.Text)) ||
            ((cmdCase3.Text == cmdCase6.Text) && (cmdCase3.Text == cmdCase9.Text)))
            {
                if (joueur == true)
                {
                    vainqueur.Text = "Le joueur 1 à gagné !!!";
                    vainqueur.ForeColor = Color.Yellow;
                    vainqueur.BackColor = Color.Black;
                    score1.Text = "Joueur 1 = " + victoirejoueur1;
                    score1.ForeColor = Color.Yellow;
                    victoirejoueur1++;
              

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                else
                {

                    vainqueur.Text = "Le joueur 2 à gagné !!!";
                    vainqueur.ForeColor = Color.Red;
                    vainqueur.BackColor = Color.Black;
                    score2.Text = "Joueur 2 = " + victoirejoueur2;
                    score2.ForeColor = Color.Red;
                    victoirejoueur2++;
                  

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                
            }
    
        }

        private void cmdCase4_Click(object sender, EventArgs e)
        {
            if (joueur == true)
            {
                cmdCase4.BackColor = Color.Red;
                cmdCase4.Text = "X";
                joueur = false;
            }
            else
            {
                cmdCase4.BackColor = Color.Yellow;
                cmdCase4.Text = "O";
                joueur = true;
            }
            cmdCase4.Enabled = false;

            if (((cmdCase4.Text == cmdCase1.Text) && (cmdCase4.Text == cmdCase7.Text)) ||
            ((cmdCase4.Text == cmdCase5.Text) && (cmdCase4.Text == cmdCase6.Text)))
            
            {
                if (joueur == true)
                {
                    vainqueur.Text = "Le joueur 1 à gagné !!!";
                    vainqueur.ForeColor = Color.Yellow;
                    vainqueur.BackColor = Color.Black;
                    score1.Text = "Joueur 1 = " + victoirejoueur1;
                    score1.ForeColor = Color.Yellow;
                    victoirejoueur1++;
                

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                else
                {

                    vainqueur.Text = "Le joueur 2 à gagné !!!";
                    vainqueur.ForeColor = Color.Red;
                    vainqueur.BackColor = Color.Black;
                    score2.Text = "Joueur 2 = " + victoirejoueur2;
                    score2.ForeColor = Color.Red;
                    victoirejoueur2++;
              

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                
            }
      
        }

        private void cmdCase5_Click(object sender, EventArgs e)
        {
            if (joueur == true)
            {
                cmdCase5.BackColor = Color.Red;
                cmdCase5.Text = "X";
                joueur = false;
            }
            else
            {
                cmdCase5.BackColor = Color.Yellow;
                cmdCase5.Text = "O";
                joueur = true;
            }
            cmdCase5.Enabled = false;

            if (((cmdCase5.Text == cmdCase1.Text) && (cmdCase5.Text == cmdCase9.Text)) ||
            ((cmdCase5.Text == cmdCase2.Text) && (cmdCase5.Text == cmdCase8.Text)) ||
            ((cmdCase5.Text == cmdCase3.Text) && (cmdCase5.Text == cmdCase7.Text)) ||
            ((cmdCase5.Text == cmdCase4.Text) && (cmdCase5.Text == cmdCase6.Text)))
            {
                if (joueur == true)
                {
                    vainqueur.Text = "Le joueur 1 à gagné !!!";
                    vainqueur.ForeColor = Color.Yellow;
                    vainqueur.BackColor = Color.Black;
                    score1.Text = "Joueur 1 = " + victoirejoueur1;
                    score1.ForeColor = Color.Yellow;
                    victoirejoueur1++;
             

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                else
                {

                    vainqueur.Text = "Le joueur 2 à gagné !!!";
                    vainqueur.ForeColor = Color.Red;
                    vainqueur.BackColor = Color.Black;
                    score2.Text = "Joueur 2 = " + victoirejoueur2;
                    score2.ForeColor = Color.Red;
                    victoirejoueur2++;
                  
                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                
            }
         
        }

        private void cmdCase6_Click(object sender, EventArgs e)
        {
            if (joueur == true)
            {
                cmdCase6.BackColor = Color.Red;
                cmdCase6.Text = "X";
                joueur = false;
            }
            else
            {
                cmdCase6.BackColor = Color.Yellow;
                cmdCase6.Text = "O";
                joueur = true;
            }
            cmdCase6.Enabled = false;

            if (((cmdCase6.Text == cmdCase3.Text) && (cmdCase6.Text == cmdCase9.Text)) ||
            ((cmdCase6.Text == cmdCase4.Text) && (cmdCase6.Text == cmdCase5.Text)))
           
            {
                if (joueur == true)
                {

                    vainqueur.Text = "Le joueur 1 à gagné !!!";
                    vainqueur.ForeColor = Color.Yellow;
                    vainqueur.BackColor = Color.Black;
                    score1.Text = "Joueur 1 = " + victoirejoueur1;
                    score1.ForeColor = Color.Yellow;
                    victoirejoueur1++;
               

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                else
                {

                    vainqueur.Text = "Le joueur 2 à gagné !!!";
                    vainqueur.ForeColor = Color.Red;
                    vainqueur.BackColor = Color.Black;
                    score2.Text = "Joueur 2 = " + victoirejoueur2;
                    score2.ForeColor = Color.Red;
                    victoirejoueur2++;
              

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
               
            }
      
        }

        private void cmdCase7_Click(object sender, EventArgs e)
        {
            if (joueur == true)
            {
                cmdCase7.BackColor = Color.Red;
                cmdCase7.Text = "X";
                joueur = false;
            }
            else
            {
                cmdCase7.BackColor = Color.Yellow;
                cmdCase7.Text = "O";
                joueur = true;
            }
            cmdCase7.Enabled = false;

            if (((cmdCase7.Text == cmdCase1.Text) && (cmdCase7.Text == cmdCase4.Text)) ||
            ((cmdCase7.Text == cmdCase3.Text) && (cmdCase7.Text == cmdCase5.Text)) ||
            ((cmdCase7.Text == cmdCase8.Text) && (cmdCase7.Text == cmdCase9.Text)))
            {
                if (joueur == true)
                {
                    vainqueur.Text = "Le joueur 1 à gagné !!!";
                    vainqueur.ForeColor = Color.Yellow;
                    vainqueur.BackColor = Color.Black;
                    score1.Text = "Joueur 1 = " + victoirejoueur1;
                    score1.ForeColor = Color.Yellow;
                    victoirejoueur1++;


                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                else
                {

                    vainqueur.Text = "Le joueur 2 à gagné !!!";
                    vainqueur.ForeColor = Color.Red;
                    vainqueur.BackColor = Color.Black;
                    score2.Text = "Joueur 2 = " + victoirejoueur2;
                    score2.ForeColor = Color.Red;
                    victoirejoueur2++;


                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }

            }
        }

        private void cmdCase8_Click(object sender, EventArgs e)
        {
            if (joueur == true)
            {
                cmdCase8.BackColor = Color.Red;
                cmdCase8.Text = "X";
                joueur = false;
            }
            else
            {
                cmdCase8.BackColor = Color.Yellow;
                cmdCase8.Text = "O";
                joueur = true;
            }
            cmdCase8.Enabled = false;

            if (((cmdCase8.Text == cmdCase2.Text) && (cmdCase8.Text == cmdCase5.Text)) ||
            ((cmdCase8.Text == cmdCase7.Text) && (cmdCase8.Text == cmdCase9.Text)))
            
            {
                if (joueur == true)
                {

                    vainqueur.Text = "Le joueur 1 à gagné !!!";
                    vainqueur.ForeColor = Color.Yellow;
                    vainqueur.BackColor = Color.Black;
                    score1.Text = "Joueur 1 = " + victoirejoueur1;
                    score1.ForeColor = Color.Yellow;
                    victoirejoueur1++;
                   

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                else
                {
                    vainqueur.Text = "Le joueur 2 à gagné !!!";
                    vainqueur.ForeColor = Color.Red;
                    vainqueur.BackColor = Color.Black;
                    score2.Text = "Joueur 2 = " + victoirejoueur2;
                    score2.ForeColor = Color.Red;
                    victoirejoueur2++;
                  


                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                
            }
        }

        private void cmdCase9_Click(object sender, EventArgs e)
        {
            if (joueur == true)
            {
                cmdCase9.BackColor = Color.Red;
                cmdCase9.Text = "X";
                joueur = false;
            }
            else
            {
                cmdCase9.BackColor = Color.Yellow;
                cmdCase9.Text = "O";
                joueur = true;
            }
            cmdCase9.Enabled = false;

            if (((cmdCase9.Text == cmdCase1.Text) && (cmdCase9.Text == cmdCase5.Text)) ||
            ((cmdCase9.Text == cmdCase3.Text) && (cmdCase9.Text == cmdCase6.Text)) ||
            ((cmdCase9.Text == cmdCase7.Text) && (cmdCase9.Text == cmdCase8.Text)))
            {
                if (joueur == true)
                {

                    vainqueur.Text = "Le joueur 1 à gagné !!!";
                    vainqueur.ForeColor = Color.Yellow;
                    vainqueur.BackColor = Color.Black;
                    score1.Text = "Joueur 1 = " + victoirejoueur1;
                    score1.ForeColor = Color.Yellow;
                    victoirejoueur1++;
                    

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                else
                {

                    vainqueur.Text = "Le joueur 2 à gagné !!!";
                    vainqueur.ForeColor = Color.Red;
                    vainqueur.BackColor = Color.Black;
                    score2.Text = "Joueur 2 = " + victoirejoueur2;
                    score2.ForeColor = Color.Red;
                    victoirejoueur2++;
                 
                    

                    cmdCase1.Enabled = false;
                    cmdCase2.Enabled = false;
                    cmdCase3.Enabled = false;
                    cmdCase4.Enabled = false;
                    cmdCase5.Enabled = false;
                    cmdCase6.Enabled = false;
                    cmdCase7.Enabled = false;
                    cmdCase8.Enabled = false;
                    cmdCase9.Enabled = false;
                }
                 
            }

        }

        private void cmdNew_Click(object sender, EventArgs e)
        {

            cmdCase1.Text = "";
            cmdCase1.BackColor = Color.WhiteSmoke;
            cmdCase2.Text = "";
            cmdCase2.BackColor = Color.WhiteSmoke;
            cmdCase3.Text = "";
            cmdCase3.BackColor = Color.WhiteSmoke;
            cmdCase4.Text = "";
            cmdCase4.BackColor = Color.WhiteSmoke;
            cmdCase5.Text = "";
            cmdCase5.BackColor = Color.WhiteSmoke;
            cmdCase6.Text = "";
            cmdCase6.BackColor = Color.WhiteSmoke;
            cmdCase7.Text = "";
            cmdCase7.BackColor = Color.WhiteSmoke;
            cmdCase8.Text = "";
            cmdCase8.BackColor = Color.WhiteSmoke;
            cmdCase9.Text = "";
            cmdCase9.BackColor = Color.WhiteSmoke;

            cmdCase1.Enabled = true;
            cmdCase2.Enabled = true;
            cmdCase3.Enabled = true;
            cmdCase4.Enabled = true;
            cmdCase5.Enabled = true;
            cmdCase6.Enabled = true;
            cmdCase7.Enabled = true;
            cmdCase8.Enabled = true;
            cmdCase9.Enabled = true;

        }

       
        
      
    }
}
