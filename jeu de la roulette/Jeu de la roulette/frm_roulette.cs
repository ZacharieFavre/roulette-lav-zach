using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jeu_de_la_roulette
{
    public partial class Accueil : Form
    {
        int numerotirer;
        private static int sommetotale;
        int misePaire;
        int miseImpaire;
        int miseNoir;
        int miseRouge;
        int miseLigneHaut;
        int miseLigneMil;
        int miseLigneBas;
        int mise1to12;
        int mise13to24;
        int mise25to36;
        int gain;

        
        // Liste des mises sur les numéros
        List<int> lstnumero = new List<int>(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

        private static frmLogin.Login login;

        public Accueil()
        {
            InitializeComponent();
            

        }

        public static void createLogin(frmLogin.Login log)
        {
            login = log;
            sommetotale = login.amount;
            Program.Accueil.refreshST();
        }

        private void refreshST()
        {
            txt_sommetotal.Text = sommetotale.ToString();
            txt_sommetotal.Enabled = false;
        }

        private void cmd_Valider_Click(object sender, EventArgs e)
        {
            if (txt_numeromise.Text != "")
            {
                int mise;
                int numero;

                mise = int.Parse(txt_mise.Text);
                numero = int.Parse(txt_numeromise.Text);

                if (sommetotale >= mise)
                {
                    lstnumero[numero] += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
            else
            {
                MessageBox.Show("Veuillez entrer un numéro sur lequel miser.");
            }
        }

        private void cmd_retirer_Click(object sender, EventArgs e)
        {
            int touteMise = mise13to24 + mise1to12 + mise25to36 + miseImpaire + misePaire + miseNoir + miseRouge + miseLigneHaut + miseLigneMil + miseLigneBas + lstnumero[0] + lstnumero[1] + lstnumero[2] + lstnumero[3] + lstnumero[4] + lstnumero[5] + lstnumero[6] + lstnumero[7] + lstnumero[8] + lstnumero[9] + lstnumero[10] + lstnumero[11] + lstnumero[12] + lstnumero[13] + lstnumero[14] + lstnumero[15] + lstnumero[16] + lstnumero[17] + lstnumero[18] + lstnumero[19] + lstnumero[20] + lstnumero[21] + lstnumero[22] + lstnumero[23] + lstnumero[24] + lstnumero[25] + lstnumero[26] + lstnumero[27] + lstnumero[28] + lstnumero[29] + lstnumero[30] + lstnumero[31] + lstnumero[32] + lstnumero[33] + lstnumero[34] + lstnumero[35] + lstnumero[36];
            sommetotale += touteMise;
            erease();
            txt_sommetotal.Text = sommetotale.ToString();
        }


        private void cmd_validersomme_Click(object sender, EventArgs e)
        {
            sommetotale = int.Parse(txt_sommetotal.Text);
            cmd_Valider.Enabled = true;
            cmd_validersomme.Enabled = false;
            txt_sommetotal.Enabled = false;
            txt_mise.Enabled = true;
            txt_numeromise.Enabled = true;
        }

        private void cmd_Regles_Click(object sender, EventArgs e)
        {
            frm_regles frm_regle = new frm_regles();
            frm_regle.Show();
        }
        
        private void cmd_tournerroulette_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            numerotirer = rnd.Next(0, 37);
            //LSJ
            switch (numerotirer)
            {
                case 0:
                    if (lstnumero[0] > 0) {
                        gain = lstnumero[0] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 1:
                    if (lstnumero[1] > 0) {
                        gain = lstnumero[1] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 2:
                    if (lstnumero[2] > 0) {
                        gain = lstnumero[2] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 3:
                    if (lstnumero[3] > 0) {
                        gain = lstnumero[3] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 4:
                    if (lstnumero[4] > 0) {
                        gain = lstnumero[4] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 5:
                    if (lstnumero[5] > 0) {
                        gain = lstnumero[5] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 6:
                    if (lstnumero[6] > 0) {
                        gain = lstnumero[6] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 7:
                    if (lstnumero[7] > 0) {
                        gain = lstnumero[7] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 8:
                    if (lstnumero[8] > 0) {
                        gain = lstnumero[8] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 9:
                    if (lstnumero[9] > 0) {
                        gain = lstnumero[9] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 10:
                    if (lstnumero[10] > 0) {
                        gain = lstnumero[10] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 11:
                    if (lstnumero[11] > 0) {
                        gain = lstnumero[11] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 12:
                    if (lstnumero[12] > 0) {
                        gain = lstnumero[12] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 13:
                    if (lstnumero[13] > 0) {
                        gain = lstnumero[13] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 14:
                    if (lstnumero[14] > 0) {
                        gain = lstnumero[14] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 15:
                    if (lstnumero[15] > 0) {
                        gain = lstnumero[15] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 16:
                    if (lstnumero[16] > 0) {
                        gain = lstnumero[16] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 17:
                    if (lstnumero[17] > 0) {
                        gain = lstnumero[17] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 18:
                    if (lstnumero[18] > 0) {
                        gain = lstnumero[18] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 19:
                    if (lstnumero[19] > 0) {
                        gain = lstnumero[19] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 20:
                    if (lstnumero[20] > 0) {
                        gain = lstnumero[20] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 21:
                    if (lstnumero[21] > 0) {
                        gain = lstnumero[21] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 22:
                    if (lstnumero[22] > 0) {
                        gain = lstnumero[22] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 23:
                    if (lstnumero[23] > 0) {
                        gain = lstnumero[23] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 24:
                    if (lstnumero[24] > 0) {
                        gain = lstnumero[24] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 25:
                    if (lstnumero[25] > 0) {
                        gain = lstnumero[25] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 26:
                    if (lstnumero[26] > 0) {
                        gain = lstnumero[26] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 27:
                    if (lstnumero[27] > 0) {
                        gain = lstnumero[27] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 28:
                    if (lstnumero[28] > 0) {
                        gain = lstnumero[28] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 29:
                    if (lstnumero[29] > 0) {
                        gain = lstnumero[29] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 30:
                    if (lstnumero[30] > 0) {
                        gain = lstnumero[30] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 31:
                    if (lstnumero[31] > 0) {
                        gain = lstnumero[31] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 32:
                    if (lstnumero[32] > 0) {
                        gain = lstnumero[32] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 33:
                    if (lstnumero[33] > 0) {
                        gain = lstnumero[33] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 34:
                    if (lstnumero[34] > 0) {
                        gain = lstnumero[34] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 35:
                    if (lstnumero[35] > 0) {
                        gain = lstnumero[35] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 36:
                    if (lstnumero[36] > 0) {
                        gain = lstnumero[36] * 36;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
            }
            //LSJ Paire
            if (numerotirer % 2 == 0 && misePaire > 0)
            {
                gain= misePaire * 2;
                sommetotale += gain;
                gagne();
            }
            //LSJ Impaire
            if (numerotirer % 2 != 0 && miseImpaire > 0)
            {
                gain= miseImpaire * 2;
                sommetotale += gain;
                gagne();
            }
            //ZFE Noir
            switch (numerotirer)
            {
                case 2:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 4:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 6:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 8:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 10:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 11:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 13:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 15:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 17:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 20:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 22:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 24:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 26:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 28:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 29:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 31:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 33:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 35:
                    if (miseNoir > 0) {
                        gain = miseNoir * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
            }
            //ZFE Rouge
            switch (numerotirer)
            {
                case 1:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 3:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 5:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 7:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 9:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 12:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 14:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 16:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 18:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 19:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 21:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 23:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 25:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 27:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 30:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 32:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 34:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 36:
                    if (miseRouge > 0) {
                        gain = miseRouge * 2;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
            }
            //ZFE Ligne haut
            switch (numerotirer)
            {
                case 3:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 6:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 9:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 12:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 15:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 18:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 21:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 24:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 27:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 30:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 33:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 36:
                    if (miseLigneHaut > 0) {
                        gain = miseLigneHaut * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
            }
            //ZFE Ligne milieu
            switch (numerotirer)
            {
                case 2:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 5:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 8:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 11:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 14:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 17:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 20:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 23:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 26:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 29:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 32:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 35:
                    if (miseLigneMil > 0) {
                        gain = miseLigneMil * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
            }
            //ZFE ligne bas
            switch (numerotirer)
            {
                case 1:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 4:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 7:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 10:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 13:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 16:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 19:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 22:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 25:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 28:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 31:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 34:
                    if (miseLigneBas > 0) {
                        gain = miseLigneBas * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
            }
            //LSJ 1 à 12
            switch (numerotirer)
            {
                case 1:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 2:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 3:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 4:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 5:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 6:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 7:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 8:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 9:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 10:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 11:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 12:
                    if (mise1to12 > 0) {
                        gain = mise1to12 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
            }
            //LSJ 13 à 24
            switch (numerotirer)
            {
                case 13:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 14:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 15:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 16:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 17:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 18:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 19:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 20:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 21:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 22:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 23:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 24:
                    if (mise13to24 > 0) {
                        gain = mise13to24 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
            }
            //ZFE 25 à 36
            switch (numerotirer)
            {
                case 25:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 26:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 27:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 28:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 29:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 30:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 31:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 32:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 33:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 34:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 35:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
                case 36:
                    if (mise25to36 > 0) {
                        gain = mise25to36 * 3;
                        sommetotale += gain;
                        gagne();
                    }
                    break;
            }
            txt_sommetotal.Text = sommetotale.ToString();
            frmLogin.MajSomme(sommetotale,login.Username);
            pictureBox5.ImageLocation = @"C:\\roulette-lav-zach\\jeu de la roulette\\Jeu de la roulette\\fichiers\\numero roulette\\" + numerotirer + ".png";

            erease();            
        }
        private void ActualiserMise()
        {
            lbl_mise00.Text = lstnumero[0].ToString();
            lbl_mise01.Text = lstnumero[1].ToString();
            lbl_mise02.Text = lstnumero[2].ToString();
            lbl_mise03.Text = lstnumero[3].ToString();
            lbl_mise04.Text = lstnumero[4].ToString();
            lbl_mise05.Text = lstnumero[5].ToString();
            lbl_mise06.Text = lstnumero[6].ToString();
            lbl_mise07.Text = lstnumero[7].ToString();
            lbl_mise08.Text = lstnumero[8].ToString();
            lbl_mise09.Text = lstnumero[9].ToString();
            lbl_mise10.Text = lstnumero[10].ToString();
            lbl_mise11.Text = lstnumero[11].ToString();
            lbl_mise12.Text = lstnumero[12].ToString();
            lbl_mise13.Text = lstnumero[13].ToString();
            lbl_mise14.Text = lstnumero[14].ToString();
            lbl_mise15.Text = lstnumero[15].ToString();
            lbl_mise16.Text = lstnumero[16].ToString();
            lbl_mise17.Text = lstnumero[17].ToString();
            lbl_mise18.Text = lstnumero[18].ToString();
            lbl_mise19.Text = lstnumero[19].ToString();
            lbl_mise20.Text = lstnumero[20].ToString();
            lbl_mise21.Text = lstnumero[21].ToString();
            lbl_mise22.Text = lstnumero[22].ToString();
            lbl_mise23.Text = lstnumero[23].ToString();
            lbl_mise24.Text = lstnumero[24].ToString();
            lbl_mise25.Text = lstnumero[25].ToString();
            lbl_mise26.Text = lstnumero[26].ToString();
            lbl_mise27.Text = lstnumero[27].ToString();
            lbl_mise28.Text = lstnumero[28].ToString();
            lbl_mise29.Text = lstnumero[29].ToString();
            lbl_mise30.Text = lstnumero[30].ToString();
            lbl_mise31.Text = lstnumero[31].ToString();
            lbl_mise32.Text = lstnumero[32].ToString();
            lbl_mise33.Text = lstnumero[33].ToString();
            lbl_mise34.Text = lstnumero[34].ToString();
            lbl_mise35.Text = lstnumero[35].ToString();
            lbl_mise36.Text = lstnumero[36].ToString();
            lbl_paire.Text = misePaire.ToString();
            lbl_impaire.Text = miseImpaire.ToString();
            lbl_Noir.Text = miseNoir.ToString();
            lbl_Rouge.Text = miseRouge.ToString();
            lbl_LigneHaut.Text = miseLigneHaut.ToString();
            lbl_LigneMil.Text = miseLigneMil.ToString();
            lbl_LigneBas.Text = miseLigneBas.ToString();
            lbl_1to12.Text = mise1to12.ToString();
            lbl_13to24.Text = mise13to24.ToString();
            lbl_25to36.Text = mise25to36.ToString();
        }

        private void cmd_paire_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= mise)
                {
                    misePaire += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_impair_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= mise)
                {
                    miseImpaire += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
                
        }

        private void cmd_Noir_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= mise)
                {
                    miseNoir += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_rouge_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= mise)
                {
                    miseRouge += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_LigneHaut_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= mise)
                {
                    miseLigneHaut += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_LigneMil_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= mise)
                {
                    miseLigneMil += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_LigneBas_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= mise)
                {
                    miseLigneBas += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_voisinDu0_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= 17*mise)
                {
                    lstnumero[22] += mise;
                    lstnumero[19] += mise;
                    lstnumero[18] += mise;
                    lstnumero[7] += mise;
                    lstnumero[28] += mise;
                    lstnumero[12] += mise;
                    lstnumero[35] += mise;
                    lstnumero[3] += mise;
                    lstnumero[26] += mise;
                    lstnumero[0] += mise;
                    lstnumero[32] += mise;
                    lstnumero[15] += mise;
                    lstnumero[4] += mise;
                    lstnumero[21] += mise;
                    lstnumero[2] += mise;
                    lstnumero[25] += mise;
                    lstnumero[29] += mise;
                    sommetotale -= 17 * mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_Orph_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= 8*mise)
                {
                    lstnumero[9] += mise;
                    lstnumero[31] += mise;
                    lstnumero[14] += mise;
                    lstnumero[20] += mise;
                    lstnumero[1] += mise;
                    lstnumero[17] += mise;
                    lstnumero[34] += mise;
                    lstnumero[6] += mise;
                    sommetotale -= 8 * mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_Tiers_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= 12*mise)
                {
                    lstnumero[27] += mise;
                    lstnumero[13] += mise;
                    lstnumero[36] += mise;
                    lstnumero[11] += mise;
                    lstnumero[30] += mise;
                    lstnumero[8] += mise;
                    lstnumero[23] += mise;
                    lstnumero[10] += mise;
                    lstnumero[5] += mise;
                    lstnumero[24] += mise;
                    lstnumero[16] += mise;
                    lstnumero[33] += mise;
                    sommetotale -= 12 * mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_1to12_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= mise)
                {
                    mise1to12 += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_13to24_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= mise)
                {
                    mise13to24 += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }

        private void cmd_25to36_Click(object sender, EventArgs e)
        {
            if (txt_mise.Text != "")
            {
                int mise;

                mise = int.Parse(txt_mise.Text);

                if (sommetotale >= mise)
                {
                    mise25to36 += mise;
                    sommetotale -= mise;
                }
                txt_sommetotal.Text = sommetotale.ToString();
                ActualiserMise();
            }
        }
        private void gagne()
        {
            MessageBox.Show("Tu as gagné " + gain + " sur le " + numerotirer);
        }
        private void erease()
        {
            for (int i = 0; i < 37; i++)
            {
                lstnumero[i] = 0;
            }
            misePaire = 0;
            miseImpaire = 0;
            miseRouge = 0;
            miseNoir = 0;
            miseLigneHaut = 0;
            miseLigneMil = 0;
            miseLigneBas = 0;
            mise1to12 = 0;
            mise13to24 = 0;
            mise25to36 = 0;
            ActualiserMise();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin lol = new frmLogin();
            lol.Show();
        }
    }
}
