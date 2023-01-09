namespace gestion_stock
{
    partial class UserControl2_produit_demender
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNuméro = new System.Windows.Forms.Label();
            this.tcdemendeachat = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAfficherDétail = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.chbAccepteé = new System.Windows.Forms.CheckBox();
            this.chbValidé = new System.Windows.Forms.CheckBox();
            this.mskA = new System.Windows.Forms.MaskedTextBox();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.txtNuméro = new System.Windows.Forms.TextBox();
            this.lblAccepté = new System.Windows.Forms.Label();
            this.lblValidé = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblDateDE = new System.Windows.Forms.Label();
            this.dgvrechercher = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtpoid = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.grbdesignation = new System.Windows.Forms.GroupBox();
            this.cmbMesure = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.lblajouter = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.tcdemendeachat.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrechercher)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grbdesignation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuméro
            // 
            this.lblNuméro.AutoSize = true;
            this.lblNuméro.Location = new System.Drawing.Point(6, 20);
            this.lblNuméro.Name = "lblNuméro";
            this.lblNuméro.Size = new System.Drawing.Size(44, 13);
            this.lblNuméro.TabIndex = 1;
            this.lblNuméro.Text = "Numéro";
            // 
            // tcdemendeachat
            // 
            this.tcdemendeachat.Controls.Add(this.tabPage1);
            this.tcdemendeachat.Controls.Add(this.tabPage2);
            this.tcdemendeachat.Location = new System.Drawing.Point(3, 3);
            this.tcdemendeachat.Name = "tcdemendeachat";
            this.tcdemendeachat.SelectedIndex = 0;
            this.tcdemendeachat.Size = new System.Drawing.Size(929, 524);
            this.tcdemendeachat.TabIndex = 111;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.Controls.Add(this.btnQuitter);
            this.tabPage1.Controls.Add(this.btnSupprimer);
            this.tabPage1.Controls.Add(this.btnAfficherDétail);
            this.tabPage1.Controls.Add(this.btnModifier);
            this.tabPage1.Controls.Add(this.btnNouveau);
            this.tabPage1.Controls.Add(this.btnRechercher);
            this.tabPage1.Controls.Add(this.chbAccepteé);
            this.tabPage1.Controls.Add(this.chbValidé);
            this.tabPage1.Controls.Add(this.mskA);
            this.tabPage1.Controls.Add(this.mskDate);
            this.tabPage1.Controls.Add(this.txtNuméro);
            this.tabPage1.Controls.Add(this.lblAccepté);
            this.tabPage1.Controls.Add(this.lblValidé);
            this.tabPage1.Controls.Add(this.lblA);
            this.tabPage1.Controls.Add(this.lblDateDE);
            this.tabPage1.Controls.Add(this.lblNuméro);
            this.tabPage1.Controls.Add(this.dgvrechercher);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(921, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recherche";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(525, 435);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(104, 37);
            this.btnQuitter.TabIndex = 16;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(395, 435);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(124, 37);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAfficherDétail
            // 
            this.btnAfficherDétail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherDétail.Location = new System.Drawing.Point(231, 435);
            this.btnAfficherDétail.Name = "btnAfficherDétail";
            this.btnAfficherDétail.Size = new System.Drawing.Size(158, 37);
            this.btnAfficherDétail.TabIndex = 14;
            this.btnAfficherDétail.Text = "AfficherDétail";
            this.btnAfficherDétail.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(125, 435);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 37);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(9, 435);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(110, 37);
            this.btnNouveau.TabIndex = 12;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(433, 63);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(131, 29);
            this.btnRechercher.TabIndex = 11;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // chbAccepteé
            // 
            this.chbAccepteé.AutoSize = true;
            this.chbAccepteé.Location = new System.Drawing.Point(703, 20);
            this.chbAccepteé.Name = "chbAccepteé";
            this.chbAccepteé.Size = new System.Drawing.Size(15, 14);
            this.chbAccepteé.TabIndex = 10;
            this.chbAccepteé.UseVisualStyleBackColor = true;
            // 
            // chbValidé
            // 
            this.chbValidé.AutoSize = true;
            this.chbValidé.Location = new System.Drawing.Point(588, 20);
            this.chbValidé.Name = "chbValidé";
            this.chbValidé.Size = new System.Drawing.Size(15, 14);
            this.chbValidé.TabIndex = 9;
            this.chbValidé.UseVisualStyleBackColor = true;
            // 
            // mskA
            // 
            this.mskA.Location = new System.Drawing.Point(419, 17);
            this.mskA.Mask = "00/00/0000";
            this.mskA.Name = "mskA";
            this.mskA.Size = new System.Drawing.Size(100, 20);
            this.mskA.TabIndex = 8;
            this.mskA.ValidatingType = typeof(System.DateTime);
            // 
            // mskDate
            // 
            this.mskDate.Location = new System.Drawing.Point(258, 17);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(100, 20);
            this.mskDate.TabIndex = 7;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtNuméro
            // 
            this.txtNuméro.Location = new System.Drawing.Point(73, 17);
            this.txtNuméro.Name = "txtNuméro";
            this.txtNuméro.Size = new System.Drawing.Size(100, 20);
            this.txtNuméro.TabIndex = 6;
            // 
            // lblAccepté
            // 
            this.lblAccepté.AutoSize = true;
            this.lblAccepté.Location = new System.Drawing.Point(638, 20);
            this.lblAccepté.Name = "lblAccepté";
            this.lblAccepté.Size = new System.Drawing.Size(47, 13);
            this.lblAccepté.TabIndex = 5;
            this.lblAccepté.Text = "Accepté";
            // 
            // lblValidé
            // 
            this.lblValidé.AutoSize = true;
            this.lblValidé.Location = new System.Drawing.Point(537, 20);
            this.lblValidé.Name = "lblValidé";
            this.lblValidé.Size = new System.Drawing.Size(36, 13);
            this.lblValidé.TabIndex = 4;
            this.lblValidé.Text = "Validé";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(388, 20);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A";
            // 
            // lblDateDE
            // 
            this.lblDateDE.AutoSize = true;
            this.lblDateDE.Location = new System.Drawing.Point(193, 20);
            this.lblDateDE.Name = "lblDateDE";
            this.lblDateDE.Size = new System.Drawing.Size(45, 13);
            this.lblDateDE.TabIndex = 2;
            this.lblDateDE.Text = "DateDE";
            // 
            // dgvrechercher
            // 
            this.dgvrechercher.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvrechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvrechercher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrechercher.Location = new System.Drawing.Point(6, 98);
            this.dgvrechercher.Name = "dgvrechercher";
            this.dgvrechercher.Size = new System.Drawing.Size(715, 331);
            this.dgvrechercher.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Azure;
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(921, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SaisirDesDemende";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::gestion_stock.Properties.Resources.Harwen_Simple_RUN;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(825, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 38);
            this.button2.TabIndex = 133;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 495);
            this.tabControl1.TabIndex = 135;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtpoid);
            this.tabPage3.Controls.Add(this.txtnom);
            this.tabPage3.Controls.Add(this.txtnum);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.grbdesignation);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.txtrecherche);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btnAjouter);
            this.tabPage3.Controls.Add(this.btnRecherche);
            this.tabPage3.Controls.Add(this.lblajouter);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(910, 469);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Produit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(910, 469);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Catalogue";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtpoid
            // 
            this.txtpoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpoid.Location = new System.Drawing.Point(22, 128);
            this.txtpoid.Name = "txtpoid";
            this.txtpoid.Size = new System.Drawing.Size(229, 29);
            this.txtpoid.TabIndex = 134;
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(22, 78);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(229, 29);
            this.txtnom.TabIndex = 135;
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(22, 28);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(229, 29);
            this.txtnum.TabIndex = 136;
            // 
            // button1
            // 
            this.button1.AccessibleName = "";
            this.button1.Image = global::gestion_stock.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_New;
            this.button1.Location = new System.Drawing.Point(186, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 38);
            this.button1.TabIndex = 145;
            this.button1.Text = " ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::gestion_stock.Properties.Resources.Custom_Icon_Design_Flatastic_4_Ticket_remove;
            this.button3.Location = new System.Drawing.Point(184, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 38);
            this.button3.TabIndex = 143;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 142;
            this.label1.Text = "Modifier";
            // 
            // button4
            // 
            this.button4.Image = global::gestion_stock.Properties.Resources.Papirus_Team_Papirus_Status_Changes_prevent;
            this.button4.Location = new System.Drawing.Point(22, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 38);
            this.button4.TabIndex = 141;
            this.button4.Text = " ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // grbdesignation
            // 
            this.grbdesignation.Controls.Add(this.cmbMesure);
            this.grbdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdesignation.Location = new System.Drawing.Point(5, 173);
            this.grbdesignation.Name = "grbdesignation";
            this.grbdesignation.Size = new System.Drawing.Size(255, 55);
            this.grbdesignation.TabIndex = 140;
            this.grbdesignation.TabStop = false;
            this.grbdesignation.Text = "Mesure:";
            // 
            // cmbMesure
            // 
            this.cmbMesure.FormattingEnabled = true;
            this.cmbMesure.Items.AddRange(new object[] {
            "Piece",
            "Litre",
            "Killo"});
            this.cmbMesure.Location = new System.Drawing.Point(20, 23);
            this.cmbMesure.Name = "cmbMesure";
            this.cmbMesure.Size = new System.Drawing.Size(229, 26);
            this.cmbMesure.TabIndex = 93;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(371, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 150;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 150);
            this.dataGridView1.TabIndex = 149;
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(439, 279);
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(166, 20);
            this.txtrecherche.TabIndex = 147;
            // 
            // label3
            // 
            this.label3.AccessibleName = "btnNouveau";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 146;
            this.label3.Text = "Nouveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 144;
            this.label2.Text = "Supprimer";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::gestion_stock.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Add_item;
            this.btnAjouter.Location = new System.Drawing.Point(22, 250);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(55, 38);
            this.btnAjouter.TabIndex = 138;
            this.btnAjouter.Text = " ";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Image = global::gestion_stock.Properties.Resources.Iconleak_Atrous_Search;
            this.btnRecherche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecherche.Location = new System.Drawing.Point(644, 279);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(144, 38);
            this.btnRecherche.TabIndex = 148;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecherche.UseVisualStyleBackColor = true;
            // 
            // lblajouter
            // 
            this.lblajouter.AutoSize = true;
            this.lblajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblajouter.Location = new System.Drawing.Point(83, 261);
            this.lblajouter.Name = "lblajouter";
            this.lblajouter.Size = new System.Drawing.Size(50, 16);
            this.lblajouter.TabIndex = 139;
            this.lblajouter.Text = "Ajouter";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(685, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 24);
            this.button6.TabIndex = 137;
            this.button6.Text = "image_produit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // UserControl2_produit_demender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tcdemendeachat);
            this.Name = "UserControl2_produit_demender";
            this.Size = new System.Drawing.Size(932, 532);
            this.Load += new System.EventHandler(this.UserControl2_produit_demender_Load);
            this.tcdemendeachat.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrechercher)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grbdesignation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNuméro;
        private System.Windows.Forms.TabControl tcdemendeachat;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAfficherDétail;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.CheckBox chbAccepteé;
        private System.Windows.Forms.CheckBox chbValidé;
        private System.Windows.Forms.MaskedTextBox mskA;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private System.Windows.Forms.TextBox txtNuméro;
        private System.Windows.Forms.Label lblAccepté;
        private System.Windows.Forms.Label lblValidé;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblDateDE;
        private System.Windows.Forms.DataGridView dgvrechercher;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtpoid;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox grbdesignation;
        private System.Windows.Forms.ComboBox cmbMesure;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label lblajouter;
        private System.Windows.Forms.Button button6;
    }
}
