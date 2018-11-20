namespace Jeu_de_la_roulette
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.txt_mise = new System.Windows.Forms.TextBox();
            this.lbl_mise = new System.Windows.Forms.Label();
            this.cmd_Valider = new System.Windows.Forms.Button();
            this.cmd_Regles = new System.Windows.Forms.Button();
            this.txt_sommetotal = new System.Windows.Forms.TextBox();
            this.lbl_sommetotal = new System.Windows.Forms.Label();
            this.cmd_validersomme = new System.Windows.Forms.Button();
            this.cmd_tournerroulette = new System.Windows.Forms.Button();
            this.txt_numeromise = new System.Windows.Forms.TextBox();
            this.lbl_numeromise = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_mise01 = new System.Windows.Forms.Label();
            this.lbl_mise02 = new System.Windows.Forms.Label();
            this.lbl_mise03 = new System.Windows.Forms.Label();
            this.lbl_mise04 = new System.Windows.Forms.Label();
            this.lbl_mise05 = new System.Windows.Forms.Label();
            this.lbl_mise06 = new System.Windows.Forms.Label();
            this.lbl_mise07 = new System.Windows.Forms.Label();
            this.lbl_mise08 = new System.Windows.Forms.Label();
            this.lbl_mise09 = new System.Windows.Forms.Label();
            this.lbl_mise10 = new System.Windows.Forms.Label();
            this.lbl_mise11 = new System.Windows.Forms.Label();
            this.lbl_mise12 = new System.Windows.Forms.Label();
            this.lbl_mise13 = new System.Windows.Forms.Label();
            this.lbl_mise15 = new System.Windows.Forms.Label();
            this.lbl_mise14 = new System.Windows.Forms.Label();
            this.lbl_mise17 = new System.Windows.Forms.Label();
            this.lbl_mise16 = new System.Windows.Forms.Label();
            this.lbl_mise18 = new System.Windows.Forms.Label();
            this.lbl_mise20 = new System.Windows.Forms.Label();
            this.lbl_mise21 = new System.Windows.Forms.Label();
            this.lbl_mise19 = new System.Windows.Forms.Label();
            this.lbl_mise22 = new System.Windows.Forms.Label();
            this.lbl_mise24 = new System.Windows.Forms.Label();
            this.lbl_mise23 = new System.Windows.Forms.Label();
            this.lbl_mise25 = new System.Windows.Forms.Label();
            this.lbl_mise27 = new System.Windows.Forms.Label();
            this.lbl_mise26 = new System.Windows.Forms.Label();
            this.lbl_mise29 = new System.Windows.Forms.Label();
            this.lbl_mise30 = new System.Windows.Forms.Label();
            this.lbl_mise32 = new System.Windows.Forms.Label();
            this.lbl_mise33 = new System.Windows.Forms.Label();
            this.lbl_mise31 = new System.Windows.Forms.Label();
            this.lbl_mise35 = new System.Windows.Forms.Label();
            this.lbl_mise34 = new System.Windows.Forms.Label();
            this.lbl_mise00 = new System.Windows.Forms.Label();
            this.lbl_mise36 = new System.Windows.Forms.Label();
            this.lbl_mise28 = new System.Windows.Forms.Label();
            this.cmd_retirer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mise
            // 
            this.txt_mise.Location = new System.Drawing.Point(212, 384);
            this.txt_mise.Name = "txt_mise";
            this.txt_mise.Size = new System.Drawing.Size(100, 20);
            this.txt_mise.TabIndex = 0;
            // 
            // lbl_mise
            // 
            this.lbl_mise.AutoSize = true;
            this.lbl_mise.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mise.Location = new System.Drawing.Point(8, 382);
            this.lbl_mise.Name = "lbl_mise";
            this.lbl_mise.Size = new System.Drawing.Size(172, 23);
            this.lbl_mise.TabIndex = 1;
            this.lbl_mise.Text = "Insérez votre mise :";
            // 
            // cmd_Valider
            // 
            this.cmd_Valider.BackgroundImage = global::Jeu_de_la_roulette.Properties.Resources.BoutonsValider_03;
            this.cmd_Valider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_Valider.Enabled = false;
            this.cmd_Valider.Location = new System.Drawing.Point(425, 359);
            this.cmd_Valider.Name = "cmd_Valider";
            this.cmd_Valider.Size = new System.Drawing.Size(148, 64);
            this.cmd_Valider.TabIndex = 2;
            this.cmd_Valider.UseCompatibleTextRendering = true;
            this.cmd_Valider.UseVisualStyleBackColor = true;
            this.cmd_Valider.Click += new System.EventHandler(this.cmd_Valider_Click);
            // 
            // cmd_Regles
            // 
            this.cmd_Regles.Location = new System.Drawing.Point(526, 33);
            this.cmd_Regles.Name = "cmd_Regles";
            this.cmd_Regles.Size = new System.Drawing.Size(75, 23);
            this.cmd_Regles.TabIndex = 3;
            this.cmd_Regles.Text = "Règles";
            this.cmd_Regles.UseVisualStyleBackColor = true;
            this.cmd_Regles.Click += new System.EventHandler(this.cmd_Regles_Click);
            // 
            // txt_sommetotal
            // 
            this.txt_sommetotal.Location = new System.Drawing.Point(207, 37);
            this.txt_sommetotal.Name = "txt_sommetotal";
            this.txt_sommetotal.Size = new System.Drawing.Size(100, 20);
            this.txt_sommetotal.TabIndex = 6;
            // 
            // lbl_sommetotal
            // 
            this.lbl_sommetotal.AutoSize = true;
            this.lbl_sommetotal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sommetotal.Location = new System.Drawing.Point(68, 37);
            this.lbl_sommetotal.Name = "lbl_sommetotal";
            this.lbl_sommetotal.Size = new System.Drawing.Size(129, 23);
            this.lbl_sommetotal.TabIndex = 7;
            this.lbl_sommetotal.Text = "Somme totale :";
            // 
            // cmd_validersomme
            // 
            this.cmd_validersomme.BackgroundImage = global::Jeu_de_la_roulette.Properties.Resources.Boutons_03;
            this.cmd_validersomme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_validersomme.Location = new System.Drawing.Point(340, 12);
            this.cmd_validersomme.Name = "cmd_validersomme";
            this.cmd_validersomme.Size = new System.Drawing.Size(148, 64);
            this.cmd_validersomme.TabIndex = 8;
            this.cmd_validersomme.UseVisualStyleBackColor = true;
            this.cmd_validersomme.Click += new System.EventHandler(this.cmd_validersomme_Click);
            // 
            // cmd_tournerroulette
            // 
            this.cmd_tournerroulette.Location = new System.Drawing.Point(722, 525);
            this.cmd_tournerroulette.Name = "cmd_tournerroulette";
            this.cmd_tournerroulette.Size = new System.Drawing.Size(109, 23);
            this.cmd_tournerroulette.TabIndex = 10;
            this.cmd_tournerroulette.Text = "Tourner la roulette";
            this.cmd_tournerroulette.UseVisualStyleBackColor = true;
            this.cmd_tournerroulette.Click += new System.EventHandler(this.cmd_tournerroulette_Click);
            // 
            // txt_numeromise
            // 
            this.txt_numeromise.Location = new System.Drawing.Point(341, 384);
            this.txt_numeromise.Name = "txt_numeromise";
            this.txt_numeromise.Size = new System.Drawing.Size(52, 20);
            this.txt_numeromise.TabIndex = 11;
            // 
            // lbl_numeromise
            // 
            this.lbl_numeromise.AutoSize = true;
            this.lbl_numeromise.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeromise.Location = new System.Drawing.Point(336, 358);
            this.lbl_numeromise.Name = "lbl_numeromise";
            this.lbl_numeromise.Size = new System.Drawing.Size(68, 23);
            this.lbl_numeromise.TabIndex = 12;
            this.lbl_numeromise.Text = "Numéro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_mise01
            // 
            this.lbl_mise01.BackColor = System.Drawing.Color.White;
            this.lbl_mise01.Location = new System.Drawing.Point(70, 649);
            this.lbl_mise01.Name = "lbl_mise01";
            this.lbl_mise01.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise01.TabIndex = 15;
            this.lbl_mise01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise02
            // 
            this.lbl_mise02.BackColor = System.Drawing.Color.White;
            this.lbl_mise02.Location = new System.Drawing.Point(70, 580);
            this.lbl_mise02.Name = "lbl_mise02";
            this.lbl_mise02.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise02.TabIndex = 16;
            this.lbl_mise02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise03
            // 
            this.lbl_mise03.BackColor = System.Drawing.Color.White;
            this.lbl_mise03.Location = new System.Drawing.Point(70, 510);
            this.lbl_mise03.Name = "lbl_mise03";
            this.lbl_mise03.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise03.TabIndex = 17;
            this.lbl_mise03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise04
            // 
            this.lbl_mise04.BackColor = System.Drawing.Color.White;
            this.lbl_mise04.Location = new System.Drawing.Point(124, 649);
            this.lbl_mise04.Name = "lbl_mise04";
            this.lbl_mise04.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise04.TabIndex = 18;
            this.lbl_mise04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise05
            // 
            this.lbl_mise05.BackColor = System.Drawing.Color.White;
            this.lbl_mise05.Location = new System.Drawing.Point(124, 580);
            this.lbl_mise05.Name = "lbl_mise05";
            this.lbl_mise05.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise05.TabIndex = 19;
            this.lbl_mise05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise06
            // 
            this.lbl_mise06.BackColor = System.Drawing.Color.White;
            this.lbl_mise06.Location = new System.Drawing.Point(124, 510);
            this.lbl_mise06.Name = "lbl_mise06";
            this.lbl_mise06.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise06.TabIndex = 20;
            this.lbl_mise06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise07
            // 
            this.lbl_mise07.BackColor = System.Drawing.Color.White;
            this.lbl_mise07.Location = new System.Drawing.Point(178, 649);
            this.lbl_mise07.Name = "lbl_mise07";
            this.lbl_mise07.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise07.TabIndex = 21;
            this.lbl_mise07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise08
            // 
            this.lbl_mise08.BackColor = System.Drawing.Color.White;
            this.lbl_mise08.Location = new System.Drawing.Point(178, 580);
            this.lbl_mise08.Name = "lbl_mise08";
            this.lbl_mise08.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise08.TabIndex = 22;
            this.lbl_mise08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise09
            // 
            this.lbl_mise09.BackColor = System.Drawing.Color.White;
            this.lbl_mise09.Location = new System.Drawing.Point(178, 510);
            this.lbl_mise09.Name = "lbl_mise09";
            this.lbl_mise09.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise09.TabIndex = 23;
            this.lbl_mise09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise10
            // 
            this.lbl_mise10.BackColor = System.Drawing.Color.White;
            this.lbl_mise10.Location = new System.Drawing.Point(233, 649);
            this.lbl_mise10.Name = "lbl_mise10";
            this.lbl_mise10.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise10.TabIndex = 24;
            this.lbl_mise10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise11
            // 
            this.lbl_mise11.BackColor = System.Drawing.Color.White;
            this.lbl_mise11.Location = new System.Drawing.Point(233, 580);
            this.lbl_mise11.Name = "lbl_mise11";
            this.lbl_mise11.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise11.TabIndex = 25;
            this.lbl_mise11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise12
            // 
            this.lbl_mise12.BackColor = System.Drawing.Color.White;
            this.lbl_mise12.Location = new System.Drawing.Point(233, 510);
            this.lbl_mise12.Name = "lbl_mise12";
            this.lbl_mise12.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise12.TabIndex = 26;
            this.lbl_mise12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise13
            // 
            this.lbl_mise13.BackColor = System.Drawing.Color.White;
            this.lbl_mise13.Location = new System.Drawing.Point(286, 649);
            this.lbl_mise13.Name = "lbl_mise13";
            this.lbl_mise13.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise13.TabIndex = 27;
            this.lbl_mise13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise15
            // 
            this.lbl_mise15.BackColor = System.Drawing.Color.White;
            this.lbl_mise15.Location = new System.Drawing.Point(286, 510);
            this.lbl_mise15.Name = "lbl_mise15";
            this.lbl_mise15.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise15.TabIndex = 28;
            this.lbl_mise15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise14
            // 
            this.lbl_mise14.BackColor = System.Drawing.Color.White;
            this.lbl_mise14.Location = new System.Drawing.Point(286, 580);
            this.lbl_mise14.Name = "lbl_mise14";
            this.lbl_mise14.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise14.TabIndex = 29;
            this.lbl_mise14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise17
            // 
            this.lbl_mise17.BackColor = System.Drawing.Color.White;
            this.lbl_mise17.Location = new System.Drawing.Point(340, 580);
            this.lbl_mise17.Name = "lbl_mise17";
            this.lbl_mise17.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise17.TabIndex = 30;
            this.lbl_mise17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise16
            // 
            this.lbl_mise16.BackColor = System.Drawing.Color.White;
            this.lbl_mise16.Location = new System.Drawing.Point(340, 649);
            this.lbl_mise16.Name = "lbl_mise16";
            this.lbl_mise16.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise16.TabIndex = 31;
            this.lbl_mise16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise18
            // 
            this.lbl_mise18.BackColor = System.Drawing.Color.White;
            this.lbl_mise18.Location = new System.Drawing.Point(340, 510);
            this.lbl_mise18.Name = "lbl_mise18";
            this.lbl_mise18.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise18.TabIndex = 32;
            this.lbl_mise18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise20
            // 
            this.lbl_mise20.BackColor = System.Drawing.Color.White;
            this.lbl_mise20.Location = new System.Drawing.Point(394, 580);
            this.lbl_mise20.Name = "lbl_mise20";
            this.lbl_mise20.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise20.TabIndex = 33;
            this.lbl_mise20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise21
            // 
            this.lbl_mise21.BackColor = System.Drawing.Color.White;
            this.lbl_mise21.Location = new System.Drawing.Point(394, 510);
            this.lbl_mise21.Name = "lbl_mise21";
            this.lbl_mise21.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise21.TabIndex = 34;
            this.lbl_mise21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise19
            // 
            this.lbl_mise19.BackColor = System.Drawing.Color.White;
            this.lbl_mise19.Location = new System.Drawing.Point(394, 649);
            this.lbl_mise19.Name = "lbl_mise19";
            this.lbl_mise19.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise19.TabIndex = 35;
            this.lbl_mise19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise22
            // 
            this.lbl_mise22.BackColor = System.Drawing.Color.White;
            this.lbl_mise22.Location = new System.Drawing.Point(448, 649);
            this.lbl_mise22.Name = "lbl_mise22";
            this.lbl_mise22.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise22.TabIndex = 36;
            this.lbl_mise22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise24
            // 
            this.lbl_mise24.BackColor = System.Drawing.Color.White;
            this.lbl_mise24.Location = new System.Drawing.Point(448, 510);
            this.lbl_mise24.Name = "lbl_mise24";
            this.lbl_mise24.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise24.TabIndex = 37;
            this.lbl_mise24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise23
            // 
            this.lbl_mise23.BackColor = System.Drawing.Color.White;
            this.lbl_mise23.Location = new System.Drawing.Point(448, 580);
            this.lbl_mise23.Name = "lbl_mise23";
            this.lbl_mise23.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise23.TabIndex = 38;
            this.lbl_mise23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise25
            // 
            this.lbl_mise25.BackColor = System.Drawing.Color.White;
            this.lbl_mise25.Location = new System.Drawing.Point(502, 649);
            this.lbl_mise25.Name = "lbl_mise25";
            this.lbl_mise25.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise25.TabIndex = 39;
            this.lbl_mise25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise27
            // 
            this.lbl_mise27.BackColor = System.Drawing.Color.White;
            this.lbl_mise27.Location = new System.Drawing.Point(502, 510);
            this.lbl_mise27.Name = "lbl_mise27";
            this.lbl_mise27.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise27.TabIndex = 40;
            this.lbl_mise27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise26
            // 
            this.lbl_mise26.BackColor = System.Drawing.Color.White;
            this.lbl_mise26.Location = new System.Drawing.Point(502, 580);
            this.lbl_mise26.Name = "lbl_mise26";
            this.lbl_mise26.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise26.TabIndex = 41;
            this.lbl_mise26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise29
            // 
            this.lbl_mise29.BackColor = System.Drawing.Color.White;
            this.lbl_mise29.Location = new System.Drawing.Point(555, 580);
            this.lbl_mise29.Name = "lbl_mise29";
            this.lbl_mise29.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise29.TabIndex = 42;
            this.lbl_mise29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise30
            // 
            this.lbl_mise30.BackColor = System.Drawing.Color.White;
            this.lbl_mise30.Location = new System.Drawing.Point(555, 510);
            this.lbl_mise30.Name = "lbl_mise30";
            this.lbl_mise30.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise30.TabIndex = 43;
            this.lbl_mise30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise32
            // 
            this.lbl_mise32.BackColor = System.Drawing.Color.White;
            this.lbl_mise32.Location = new System.Drawing.Point(609, 580);
            this.lbl_mise32.Name = "lbl_mise32";
            this.lbl_mise32.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise32.TabIndex = 44;
            this.lbl_mise32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise33
            // 
            this.lbl_mise33.BackColor = System.Drawing.Color.White;
            this.lbl_mise33.Location = new System.Drawing.Point(609, 510);
            this.lbl_mise33.Name = "lbl_mise33";
            this.lbl_mise33.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise33.TabIndex = 45;
            this.lbl_mise33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise31
            // 
            this.lbl_mise31.BackColor = System.Drawing.Color.White;
            this.lbl_mise31.Location = new System.Drawing.Point(609, 649);
            this.lbl_mise31.Name = "lbl_mise31";
            this.lbl_mise31.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise31.TabIndex = 46;
            this.lbl_mise31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise35
            // 
            this.lbl_mise35.BackColor = System.Drawing.Color.White;
            this.lbl_mise35.Location = new System.Drawing.Point(663, 580);
            this.lbl_mise35.Name = "lbl_mise35";
            this.lbl_mise35.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise35.TabIndex = 47;
            this.lbl_mise35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise34
            // 
            this.lbl_mise34.BackColor = System.Drawing.Color.White;
            this.lbl_mise34.Location = new System.Drawing.Point(663, 649);
            this.lbl_mise34.Name = "lbl_mise34";
            this.lbl_mise34.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise34.TabIndex = 48;
            this.lbl_mise34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise00
            // 
            this.lbl_mise00.BackColor = System.Drawing.Color.White;
            this.lbl_mise00.Location = new System.Drawing.Point(17, 580);
            this.lbl_mise00.Name = "lbl_mise00";
            this.lbl_mise00.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise00.TabIndex = 49;
            this.lbl_mise00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise36
            // 
            this.lbl_mise36.BackColor = System.Drawing.Color.White;
            this.lbl_mise36.Location = new System.Drawing.Point(663, 510);
            this.lbl_mise36.Name = "lbl_mise36";
            this.lbl_mise36.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise36.TabIndex = 50;
            this.lbl_mise36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mise28
            // 
            this.lbl_mise28.BackColor = System.Drawing.Color.White;
            this.lbl_mise28.Location = new System.Drawing.Point(555, 649);
            this.lbl_mise28.Name = "lbl_mise28";
            this.lbl_mise28.Size = new System.Drawing.Size(46, 13);
            this.lbl_mise28.TabIndex = 51;
            this.lbl_mise28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_retirer
            // 
            this.cmd_retirer.Location = new System.Drawing.Point(622, 360);
            this.cmd_retirer.Name = "cmd_retirer";
            this.cmd_retirer.Size = new System.Drawing.Size(75, 23);
            this.cmd_retirer.TabIndex = 52;
            this.cmd_retirer.Text = "Retirer";
            this.cmd_retirer.UseVisualStyleBackColor = true;
            this.cmd_retirer.Click += new System.EventHandler(this.cmd_retirer_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cmd_retirer);
            this.Controls.Add(this.lbl_mise28);
            this.Controls.Add(this.lbl_mise36);
            this.Controls.Add(this.lbl_mise00);
            this.Controls.Add(this.lbl_mise34);
            this.Controls.Add(this.lbl_mise35);
            this.Controls.Add(this.lbl_mise31);
            this.Controls.Add(this.lbl_mise33);
            this.Controls.Add(this.lbl_mise32);
            this.Controls.Add(this.lbl_mise30);
            this.Controls.Add(this.lbl_mise29);
            this.Controls.Add(this.lbl_mise26);
            this.Controls.Add(this.lbl_mise27);
            this.Controls.Add(this.lbl_mise25);
            this.Controls.Add(this.lbl_mise23);
            this.Controls.Add(this.lbl_mise24);
            this.Controls.Add(this.lbl_mise22);
            this.Controls.Add(this.lbl_mise19);
            this.Controls.Add(this.lbl_mise21);
            this.Controls.Add(this.lbl_mise20);
            this.Controls.Add(this.lbl_mise18);
            this.Controls.Add(this.lbl_mise16);
            this.Controls.Add(this.lbl_mise17);
            this.Controls.Add(this.lbl_mise14);
            this.Controls.Add(this.lbl_mise15);
            this.Controls.Add(this.lbl_mise13);
            this.Controls.Add(this.lbl_mise12);
            this.Controls.Add(this.lbl_mise11);
            this.Controls.Add(this.lbl_mise10);
            this.Controls.Add(this.lbl_mise09);
            this.Controls.Add(this.lbl_mise08);
            this.Controls.Add(this.lbl_mise07);
            this.Controls.Add(this.lbl_mise06);
            this.Controls.Add(this.lbl_mise05);
            this.Controls.Add(this.lbl_mise04);
            this.Controls.Add(this.lbl_mise03);
            this.Controls.Add(this.lbl_mise02);
            this.Controls.Add(this.lbl_mise01);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_numeromise);
            this.Controls.Add(this.txt_numeromise);
            this.Controls.Add(this.cmd_tournerroulette);
            this.Controls.Add(this.cmd_validersomme);
            this.Controls.Add(this.lbl_sommetotal);
            this.Controls.Add(this.txt_sommetotal);
            this.Controls.Add(this.cmd_Regles);
            this.Controls.Add(this.cmd_Valider);
            this.Controls.Add(this.lbl_mise);
            this.Controls.Add(this.txt_mise);
            this.Name = "Accueil";
            this.Text = "frm_roulette";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mise;
        private System.Windows.Forms.Label lbl_mise;
        private System.Windows.Forms.Button cmd_Valider;
        private System.Windows.Forms.Button cmd_Regles;
        private System.Windows.Forms.TextBox txt_sommetotal;
        private System.Windows.Forms.Label lbl_sommetotal;
        private System.Windows.Forms.Button cmd_validersomme;
        private System.Windows.Forms.Button cmd_tournerroulette;
        private System.Windows.Forms.TextBox txt_numeromise;
        private System.Windows.Forms.Label lbl_numeromise;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_mise01;
        private System.Windows.Forms.Label lbl_mise02;
        private System.Windows.Forms.Label lbl_mise03;
        private System.Windows.Forms.Label lbl_mise04;
        private System.Windows.Forms.Label lbl_mise05;
        private System.Windows.Forms.Label lbl_mise06;
        private System.Windows.Forms.Label lbl_mise07;
        private System.Windows.Forms.Label lbl_mise08;
        private System.Windows.Forms.Label lbl_mise09;
        private System.Windows.Forms.Label lbl_mise10;
        private System.Windows.Forms.Label lbl_mise11;
        private System.Windows.Forms.Label lbl_mise12;
        private System.Windows.Forms.Label lbl_mise13;
        private System.Windows.Forms.Label lbl_mise15;
        private System.Windows.Forms.Label lbl_mise14;
        private System.Windows.Forms.Label lbl_mise17;
        private System.Windows.Forms.Label lbl_mise16;
        private System.Windows.Forms.Label lbl_mise18;
        private System.Windows.Forms.Label lbl_mise20;
        private System.Windows.Forms.Label lbl_mise21;
        private System.Windows.Forms.Label lbl_mise19;
        private System.Windows.Forms.Label lbl_mise22;
        private System.Windows.Forms.Label lbl_mise24;
        private System.Windows.Forms.Label lbl_mise23;
        private System.Windows.Forms.Label lbl_mise25;
        private System.Windows.Forms.Label lbl_mise27;
        private System.Windows.Forms.Label lbl_mise26;
        private System.Windows.Forms.Label lbl_mise29;
        private System.Windows.Forms.Label lbl_mise30;
        private System.Windows.Forms.Label lbl_mise32;
        private System.Windows.Forms.Label lbl_mise33;
        private System.Windows.Forms.Label lbl_mise31;
        private System.Windows.Forms.Label lbl_mise35;
        private System.Windows.Forms.Label lbl_mise34;
        private System.Windows.Forms.Label lbl_mise00;
        private System.Windows.Forms.Label lbl_mise36;
        private System.Windows.Forms.Label lbl_mise28;
        private System.Windows.Forms.Button cmd_retirer;
    }
}

