﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_la_roulette
{
    public partial class Accueil : Form
    {
        int sommetotale;
        List<int> lstnumero = new List<int>(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
        private object pic_randomchoisi;

        public Accueil()
        {
            InitializeComponent();
            

        }

        private void cmd_Valider_Click(object sender, EventArgs e)
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

        private void cmd_retirer_Click(object sender, EventArgs e)
        {
            int mise;
            int numero;

            mise = int.Parse(txt_mise.Text);
            numero = int.Parse(txt_numeromise.Text);
            if (lstnumero[numero] <= 0)
            {
                MessageBox.Show("Vous ne pouvez plus retirer");
            }
            else
            {
                lstnumero[numero] -= mise;
                sommetotale += mise;
            }
            txt_sommetotal.Text = sommetotale.ToString();
            ActualiserMise();
        }

        private void Accueil_Load(object sender, EventArgs e)
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
        }

        private void cmd_validersomme_Click(object sender, EventArgs e)
        {
            sommetotale = int.Parse(txt_sommetotal.Text);
            cmd_Valider.Enabled = true;
            cmd_validersomme.Enabled = false;
            txt_sommetotal.Enabled = false;
        }

        private void cmd_Regles_Click(object sender, EventArgs e)
        {
            frm_regles frm_regle = new frm_regles();
            frm_regle.Show();
        }

        private void cmd_tournerroulette_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numerotirer = rnd.Next(0, 37);

            switch (numerotirer)
            {
                case 0:
                    if (lstnumero[0] > 0) { sommetotale += lstnumero[0] * 36; }
                    break;
                case 1:
                    if (lstnumero[1] > 0) { sommetotale += lstnumero[1] * 36; }
                    break;
                case 2:
                    if (lstnumero[2] > 0) { sommetotale += lstnumero[2] * 36; }
                    break;
                case 3:
                    if (lstnumero[3] > 0) { sommetotale += lstnumero[3] * 36; }
                    break;
                case 4:
                    if (lstnumero[4] > 0) { sommetotale += lstnumero[4] * 36; }
                    break;
                case 5:
                    if (lstnumero[5] > 0) { sommetotale += lstnumero[5] * 36; }
                    break;
                case 6:
                    if (lstnumero[6] > 0) { sommetotale += lstnumero[6] * 36; }
                    break;
                case 7:
                    if (lstnumero[7] > 0) { sommetotale += lstnumero[7] * 36; }
                    break;
                case 8:
                    if (lstnumero[8] > 0) { sommetotale += lstnumero[8] * 36; }
                    break;
                case 9:
                    if (lstnumero[9] > 0) { sommetotale += lstnumero[9] * 36; }
                    break;
                case 10:
                    if (lstnumero[10] > 0) { sommetotale += lstnumero[10] * 36; }
                    break;
                case 11:
                    if (lstnumero[11] > 0) { sommetotale += lstnumero[11] * 36; }
                    break;
                case 12:
                    if (lstnumero[12] > 0) { sommetotale += lstnumero[12] * 36; }
                    break;
                case 13:
                    if (lstnumero[13] > 0) { sommetotale += lstnumero[13] * 36; }
                    break;
                case 14:
                    if (lstnumero[14] > 0) { sommetotale += lstnumero[14] * 36; }
                    break;
                case 15:
                    if (lstnumero[15] > 0) { sommetotale += lstnumero[15] * 36; }
                    break;
                case 16:
                    if (lstnumero[16] > 0) { sommetotale += lstnumero[16] * 36; }
                    break;
                case 17:
                    if (lstnumero[17] > 0) { sommetotale += lstnumero[17] * 36; }
                    break;
                case 18:
                    if (lstnumero[18] > 0) { sommetotale += lstnumero[18] * 36; }
                    break;
                case 19:
                    if (lstnumero[19] > 0) { sommetotale += lstnumero[19] * 36; }
                    break;
                case 20:
                    if (lstnumero[20] > 0) { sommetotale += lstnumero[20] * 36; }
                    break;
                case 21:
                    if (lstnumero[21] > 0) { sommetotale += lstnumero[21] * 36; }
                    break;
                case 22:
                    if (lstnumero[22] > 0) { sommetotale += lstnumero[22] * 36; }
                    break;
                case 23:
                    if (lstnumero[23] > 0) { sommetotale += lstnumero[23] * 36; }
                    break;
                case 24:
                    if (lstnumero[24] > 0) { sommetotale += lstnumero[24] * 36; }
                    break;
                case 25:
                    if (lstnumero[25] > 0) { sommetotale += lstnumero[25] * 36; }
                    break;
                case 26:
                    if (lstnumero[26] > 0) { sommetotale += lstnumero[26] * 36; }
                    break;
                case 27:
                    if (lstnumero[27] > 0) { sommetotale += lstnumero[27] * 36; }
                    break;
                case 28:
                    if (lstnumero[28] > 0) { sommetotale += lstnumero[28] * 36; }
                    break;
                case 29:
                    if (lstnumero[29] > 0) { sommetotale += lstnumero[29] * 36; }
                    break;
                case 30:
                    if (lstnumero[30] > 0) { sommetotale += lstnumero[30] * 36; }
                    break;
                case 31:
                    if (lstnumero[31] > 0) { sommetotale += lstnumero[31] * 36; }
                    break;
                case 32:
                    if (lstnumero[32] > 0) { sommetotale += lstnumero[32] * 36; }
                    break;
                case 33:
                    if (lstnumero[33] > 0) { sommetotale += lstnumero[33] * 36; }
                    break;
                case 34:
                    if (lstnumero[34] > 0) { sommetotale += lstnumero[34] * 36; }
                    break;
                case 35:
                    if (lstnumero[35] > 0) { sommetotale += lstnumero[35] * 36; }
                    break;
                case 36:
                    if (lstnumero[36] > 0) { sommetotale += lstnumero[36] * 36; }
                    break;
            }
            if (numerotirer % 2 == 0)
            {

            }
            txt_sommetotal.Text = sommetotale.ToString();
            //pic_randomchoisi.ImageLocation = "fichiers\\numero roulette\\" + numerotirer + ".png";
            	
            for (int i=0;i<37;i++)
            {
            	lstnumero[i] = 0;
            }
            ActualiserMise();
            			
            
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
           
        }

    }
}
