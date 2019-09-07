using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranscriptionOrokin
{
    public partial class Form1 : Form
    {
        internal int cptSpace = 5;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "p ";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "b ";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "t ";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "d ";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "s ";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "z ";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "j ";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "k ";
        } 

        private void button9_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "g ";
        }

        // fin linge 1 ========================================================= debut ligne 2

        private void button10_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "f ";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "v ";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "th ";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "dh ";
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "sh ";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "zh ";
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "ch ";
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "kh ";
        }

        // fin ligne 2 ====================================================== debut ligne 3

        private void button18_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "m ";
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "n ";
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "h ";
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "r ";
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "l ";
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "ng ";               
        }

        // fin linge 3 ================================================= debut voyelle

        private void button25_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "ee ";
        } 

        private void button26_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "i ";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "e ";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "a ";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "aw ";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "u ";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "o ";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "oo ";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "ea ";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "aye ";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "ow ";
        }

        // fin des voyel =================================================== debut caractere speciaux

        private void button37_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + ". ";
        }
        
        // fin caractere speciaux ============================================================ debut nombre 

        private void button39_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "1";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "2";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "3";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "4";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "5";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "6";
        }

        private void button45_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "7";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "8";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "9";
        }

        //  fin nombre =============================================== transcription / backspace / clear /space

        public void button24_Click_1(object sender, EventArgs e) // verif
        {
            transcriptionAuto.cpt = 0;
            transcriptionAuto.cptMax = 0;
            string transcription;
            transcription = label2.Text;
            transcriptionAuto.Verif(transcription, cptSpace);
            if (transcriptionAuto.cpt == 1)
            {
                label2.Text = ">" +  transcriptionAuto.renvoie;
                transcriptionAuto.Verif(transcription, cptSpace);

                if (transcriptionAuto.cpt == 2)
                {
                    label2.Text = label2.Text + transcriptionAuto.renvoie;
                    transcriptionAuto.Verif(transcription, cptSpace);

                    if (transcriptionAuto.cpt == 3)
                    {
                        label2.Text = label2.Text + transcriptionAuto.renvoie;
                        transcriptionAuto.Verif(transcription, cptSpace);

                        if (transcriptionAuto.cpt == 4)
                        {
                            label2.Text = label2.Text + transcriptionAuto.renvoie;
                            transcriptionAuto.Verif(transcription, cptSpace);

                            if (transcriptionAuto.cpt == 5)
                            {
                                label2.Text = label2.Text + transcriptionAuto.renvoie;
                                transcriptionAuto.Verif(transcription, cptSpace);

                                if (transcriptionAuto.cpt == 6)
                                {
                                    label2.Text = label2.Text + transcriptionAuto.renvoie;
                                    transcriptionAuto.Verif(transcription, cptSpace);
                                }
                            }
                        }
                    }
                }
            }
          //  label1.Text = label2.Text.Length.ToString();
        } //fin du bouton de transcription

        private void button48_Click(object sender, EventArgs e) //supprime le dernier mot
        {
            string a_reduire = label2.Text;
            string temp = ">";
            char[] coupure = temp.ToCharArray();
            string backSpace = "";
            


            if(cptSpace == 0) // il y a 5 espace
            {
                backSpace = a_reduire.Split(coupure)[6];
                transcriptionAuto.subLigne(backSpace, a_reduire);
            }
            else if (cptSpace == 1)
            {
                backSpace = a_reduire.Split(coupure)[5];
                transcriptionAuto.subLigne(backSpace, a_reduire);
            }
            else if (cptSpace == 2) // il y a 3 espace
            {
                backSpace = a_reduire.Split(coupure)[4];
                transcriptionAuto.subLigne(backSpace, a_reduire);
            }
            else if (cptSpace == 3)
            {
                backSpace = a_reduire.Split(coupure)[3];
                transcriptionAuto.subLigne(backSpace, a_reduire);
            }
            else if (cptSpace == 4) // il y a 1 espace
            {
                backSpace = a_reduire.Split(coupure)[2];
                transcriptionAuto.subLigne(backSpace, a_reduire);
            }
            else if (cptSpace == 5)
            {
                backSpace = a_reduire.Split(coupure)[1];
                transcriptionAuto.subLigne(backSpace, a_reduire);
            }

            
            Console.WriteLine(a_reduire);
            Console.WriteLine(backSpace);
            Console.WriteLine(transcriptionAuto.subbed);
            
            label2.Text = transcriptionAuto.subbed;
            if (cptSpace < 5)
            {
                cptSpace++;
                this.button50.Text = "Faire un espace ( " + cptSpace + " espace restants )";
            }


            if ( label2.Text.Length == 0)
            {
                label2.Text = ">";
            }
            
            /*
            char[] coupure = { '|' };
            string reduction = a_reduire.Split(coupure, StringSplitOptions.RemoveEmptyEntries)[0];
            */

        }

        private void button49_Click(object sender, EventArgs e) //vider le texte
        {
            label2.Text = ">";
            cptSpace = 5;
            this.button50.Text = "Faire un espace ( " + cptSpace + " espace restants )";
        }
        
        private void button50_Click(object sender, EventArgs e) //faire un espace
        {
            if(cptSpace > 0)
            {
                label2.Text = label2.Text + ">";
                cptSpace--;
            }
            this.button50.Text = "Faire un espace ( " + cptSpace + " espace restants )";
        }

        private void after_show_this(object sender, EventArgs e)//lance la fenetre de "tuto"
        {
            new fenetre_de_lencement().ShowDialog();
        }

        private void button36_Click(object sender, EventArgs e) // aide
        {
            new fenetre_de_lencement().ShowDialog();
        }
    }
}
