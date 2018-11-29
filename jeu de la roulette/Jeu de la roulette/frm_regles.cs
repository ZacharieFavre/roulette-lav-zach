using System;
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
    public partial class frm_regles : Form
    {
        public frm_regles()
        {
            InitializeComponent();
        }

        private void frm_regles_Load(object sender, EventArgs e)
        {
            lblRegle.Text = "Règles";
            lbl1.Text = "Le joueur peut miser sur les pairs, impairs, rouge, noir, lignes haut, bas, milieu et enfin sur un nombre.";
            lbl2.Text = "les gains :";
            lbl3.Text = "- Rouges, noirs = x2";
            lbl4.Text = "- Paires, impaires = x2";
            lbl4.Text = "- Lignes = x3";
            lbl6.Text = "- Nombre = x36";
            lbl7.Text = "Si la bille s'arrête sur un nombre gagnant le joueur gagne sa mise multipliée suivant les règles plus haut.";
            lbl8.Text = "Si la bille s'arrête sur un nombre perdant le joueur perds ce qu'il a misé.";
        }
    }
}
