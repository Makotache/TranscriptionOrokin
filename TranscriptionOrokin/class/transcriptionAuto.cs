using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TranscriptionOrokin
{
    class transcriptionAuto
    {
        internal static string renvoie = "";
        internal static short cpt = 0; //nombre de tour de verification en cours
        internal static short cptMax = 0; // nombre de tour de la boucle MAX de verification 

        public static string Verif(string recu, int cptSpaceR)
        {
            char coupure = '>'; // séparation des différent mot avec point (si existant)
            string[] reduction = recu.Split(coupure);

            char pointcoup = '.';// pour savoir si il exite un point au moins
            string[] nbPoint = recu.Split(pointcoup);

            int VerifLenTXTbase = 0; // compte le nombre de caractère pour identifier l'emplacement d'un point si il existe

            bool pass1 = false; // autorisation pour remplacer "recu" avec l'un des mot obtenue par "reduction"
            bool pass2 = false; // c'est nessaire pour mettre le mot avec un point si il existe
            bool pass3 = false;
            bool pass4 = false;
            bool pass5 = false;
            bool pass6 = false;
          

            //					initialiser le nombre de tours max de la boucle
            if (cptSpaceR == 5)
            {
                cptMax = 1; // 1 mot
            }
            else if (cptSpaceR == 4)
            {
                cptMax = 2; 
            }
            else if (cptSpaceR == 3)
            {
                cptMax = 3; // 3 mots
            }
            else if (cptSpaceR == 2)
            {
                cptMax = 4;
            }
            else if (cptSpaceR == 1)
            {
                cptMax = 5; // 5 mots
            }
            else if (cptSpaceR == 0)
            {
                cptMax = 6;
            }

			
			
            //                  début de la boucle de transcription
            while (cpt < cptMax)
            {
                cpt++;

                // remplacemet de "recu" pour verif chaque mots
                if (cpt == 1 && pass1 == false)
                {
                    recu = reduction[1];
                }
                else
                {

                    pass1 = false;
                    if (cpt == 2 && pass2 == false)
                    {
                        recu = reduction[2];
                    }
                    else
                    {
                        pass2 = false;
                        if (cpt == 3 && pass3 == false)
                        {
                            recu = reduction[3];
                        }
                        else
                        {
                            pass3 = false;
                            if (cpt == 4 && pass4 == false)
                            {
                                recu = reduction[4];
                            }
                            else
                            {
                                pass4 = false;
                                if (cpt == 5 && pass5 == false)
                                {
                                    recu = reduction[5];
                                }
                                else
                                {
                                    pass5 = false;
                                    if (cpt == 6 && pass6 == false)
                                    {
                                        recu = reduction[6];
                                    }
                                    else
                                    {
                                        pass6 = false;
                                    }
                                }
                            }
                        }
                    }
                }
                VerifLenTXTbase = VerifLenTXTbase + recu.Length;



                // debut traitement du mot recu
                dataMotsRecus.MotTranscrip(recu);
                
                string newRecu = dataMotsRecus.renvoieIntermedaire;
                if (newRecu != recu)
                {
                    renvoie = newRecu;
                    return renvoie;
                }
                else if (newRecu == "")
                {
                    return renvoie = "";
                }
                // fin du traitement et renvoie de sa transcription





                //placement du point si il est existant
                if (nbPoint.Length > 1) // pour savoir si il existe au moins un point
                {
                    if (cpt == 1)
                    {
                        if (VerifLenTXTbase == recu.Length)
                        {
                            int val = recu.Length - 2;
                            recu = recu.Substring(0, val);
                            dataMotsRecus.MotTranscrip(recu);
                            renvoie = dataMotsRecus.renvoieIntermedaire + ". ";
                            pass1 = true;
                            return renvoie;
                        }
                    }
                    else if (cpt == 2)
                    {

                        if (VerifLenTXTbase == recu.Length)
                        {
                            int val = recu.Length - 2;
                            recu = recu.Substring(0, val);
                            dataMotsRecus.MotTranscrip(recu);
                            renvoie = dataMotsRecus.renvoieIntermedaire + ". ";
                            pass2 = true;
                            return renvoie;
                        }


                    }
                    else if (cpt == 3)
                    {

                        if (VerifLenTXTbase == recu.Length)
                        {
                            int val = recu.Length - 2;
                            recu = recu.Substring(0, val);
                            dataMotsRecus.MotTranscrip(recu);
                            renvoie = dataMotsRecus.renvoieIntermedaire + ". ";
                            pass3 = true;
                            return renvoie;
                        }


                    }
                    else if (cpt == 4)
                    {

                        if (VerifLenTXTbase == recu.Length)
                        {
                            int val = recu.Length - 2;
                            recu = recu.Substring(0, val);
                            dataMotsRecus.MotTranscrip(recu);
                            renvoie = dataMotsRecus.renvoieIntermedaire + ". ";
                            pass4 = true;
                            return renvoie;
                        }


                    }
                    else if (cpt == 5)
                    {

                        if (VerifLenTXTbase == recu.Length)
                        {
                            int val = recu.Length - 2;
                            recu = recu.Substring(0, val);
                            dataMotsRecus.MotTranscrip(recu);
                            renvoie = dataMotsRecus.renvoieIntermedaire + ". ";
                            pass5 = true;
                            return renvoie;
                        }

                    }
                    else if (cpt == 6)
                    {
                        if (VerifLenTXTbase == recu.Length)
                        {
                            int val = recu.Length - 2;
                            recu = recu.Substring(0, val);
                            dataMotsRecus.MotTranscrip(recu);
                            renvoie = dataMotsRecus.renvoieIntermedaire + ". ";
                            pass6 = true;
                            return renvoie;
                        }

                    }
                }
                

            } // boucle des vérifications

            return renvoie = recu; // je met ca pour ne pas avoir d'erreur
        }


        internal static string subbed;
        
        //supprime le dernier mot
        public static string subLigne(string backspace, string a_reduire)
        {
            int nbReduction = a_reduire.Length - backspace.Length - 1;
            
            subbed = a_reduire.Substring(0, nbReduction);

            return subbed;
        }

        

    }
}
    
                    