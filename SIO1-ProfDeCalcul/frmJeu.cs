using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SIO1_ProfDeCalcul
{
    public partial class frmJeu : Form
    {
        public frmJeu()
        {
            InitializeComponent();
        }

        //---------  ESSAI MODIFICATION PAR GIT
         public static int a;
        //-----------------------------------------


        //=====================================================

        # region VARIABLES GLOBALES

        public static int resultat;
        public static int resultatAlt1;
        public static int resultatAlt2;
        public static string exercice;
        public static Random rndm;

        # endregion

        //=====================================================

        # region PROCEDURES EVENEMENTIELLES

        private void frmJeu_Load(object sender, EventArgs e)
        {

        }


        private void btnJouer_Click(object sender, EventArgs e)
        {
            // Clic sur le bouton JOUER :
            // on crée l'exercice (l'opération + les réponses possibles)
            creerExercice();
            proposerSolutions();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            // Clic sur le bouton OK :
            // Affichage de MessageBox en fonction de la réponse sélectionnée

            if (rbtnL1.Checked && rbtnL1.Text == resultat.ToString())
            {
                MessageBox.Show("BONNE REPONSE !");
            }
            else
            {
                if (rbtnL2.Checked && rbtnL2.Text == resultat.ToString())
                {
                    MessageBox.Show("BONNE REPONSE !");
                }
                else
                {
                    if (rbtnL3.Checked && rbtnL3.Text == resultat.ToString())
                    {
                        MessageBox.Show("BONNE REPONSE !");
                    }
                    else
                    {

                        MessageBox.Show("ERREUR");
                    }
                }
            }
        }


        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        # endregion

        //=====================================================

        # region PROCEDURES/FONCTIONS UTILISATEURS

        // Création de l'exercice
        private void creerExercice()
        {
            // on détermine aléatoirement les 2 membres de l'opération
            rndm = new Random();
            int nombre1 = rndm.Next(1, 21);
            int nombre2 = rndm.Next(1, 21);

            // on met en forme le label
            exercice = nombre1.ToString() + " + " + nombre2.ToString() + " = ";
            lblExercice.Text = exercice;

            // on calcule le résultat réel de l'opération
            resultat = nombre1 + nombre2;
        }


        // Recherche de 2 résultats alternatifs, différents du vrai résultat
        private void proposerSolutions()
        {
            // Le résultat a été calculé, il faut calculer les 2 résultats alternatifs.
            // Pour cela, on leur affecte une valeur aléatoire différente du résultat réel

            resultatAlt1 = resultat;
            resultatAlt2 = resultat;

            while (resultat == resultatAlt1)
            {
                resultatAlt1 = (rndm.Next(2, 41));
            }

            while (resultat == resultatAlt2 || resultatAlt1 == resultatAlt2)
            {
                resultatAlt2 = (rndm.Next(2, 41));
            }

            // On affecte le résultat réel et les 2 résultats alternatifs aux boutons radio
            // dans l'ordre croissant

            if (resultat < resultatAlt1 && resultat < resultatAlt2)
            {
                rbtnL1.Text = resultat.ToString();
                if (resultatAlt1 < resultatAlt2)
                {
                    rbtnL2.Text = resultatAlt1.ToString();
                    rbtnL3.Text = resultatAlt2.ToString();
                }
                else
                {
                    rbtnL2.Text = resultatAlt2.ToString();
                    rbtnL3.Text = resultatAlt1.ToString();
                }
            }

            if (resultatAlt1 < resultatAlt2 && resultatAlt1 < resultat)
            {
                rbtnL1.Text = resultatAlt1.ToString();
                if (resultat < resultatAlt2)
                {
                    rbtnL2.Text = resultat.ToString();
                    rbtnL3.Text = resultatAlt2.ToString();
                }
                else
                {
                    rbtnL2.Text = resultatAlt2.ToString();
                    rbtnL3.Text = resultat.ToString();
                }
            }

            if (resultatAlt2 < resultatAlt1 && resultatAlt2 < resultat)
            {
                rbtnL1.Text = resultatAlt2.ToString();
                if (resultat < resultatAlt1)
                {
                    rbtnL2.Text = resultat.ToString();
                    rbtnL3.Text = resultatAlt1.ToString();
                }
                else
                {
                    rbtnL2.Text = resultatAlt1.ToString();
                    rbtnL3.Text = resultat.ToString();
                }
            }

            // décochage des bouton radio avant leur affichage
            rbtnL1.Checked = false;
            rbtnL2.Checked = false;
            rbtnL3.Checked = false;

        }

        # endregion


    }
}
