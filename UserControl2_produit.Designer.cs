namespace gestion_stock
{
    partial class UserControl2_produit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtpoid = new System.Windows.Forms.TextBox();
            this.grbdesignation = new System.Windows.Forms.GroupBox();
            this.cmbMesure = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblajouter = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.PicE = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grbdesignation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 124;
            this.label1.Text = "Modifier";
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(26, 22);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(229, 29);
            this.txtnum.TabIndex = 82;
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            this.txtnum.Enter += new System.EventHandler(this.txtnum_Enter);
            this.txtnum.Leave += new System.EventHandler(this.txtnum_Leave);
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(26, 72);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(229, 29);
            this.txtnom.TabIndex = 82;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            this.txtnom.Enter += new System.EventHandler(this.txtnom_Enter);
            this.txtnom.Leave += new System.EventHandler(this.txtnom_Leave);
            // 
            // txtpoid
            // 
            this.txtpoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpoid.Location = new System.Drawing.Point(26, 122);
            this.txtpoid.Name = "txtpoid";
            this.txtpoid.Size = new System.Drawing.Size(229, 29);
            this.txtpoid.TabIndex = 82;
            this.txtpoid.Enter += new System.EventHandler(this.txtpoid_Enter);
            this.txtpoid.Leave += new System.EventHandler(this.txtpoid_Leave);
            // 
            // grbdesignation
            // 
            this.grbdesignation.Controls.Add(this.cmbMesure);
            this.grbdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdesignation.Location = new System.Drawing.Point(9, 167);
            this.grbdesignation.Name = "grbdesignation";
            this.grbdesignation.Size = new System.Drawing.Size(255, 55);
            this.grbdesignation.TabIndex = 122;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(371, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 133;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 150);
            this.dataGridView1.TabIndex = 132;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(439, 273);
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(166, 20);
            this.txtrecherche.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.AccessibleName = "btnNouveau";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "Nouveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 126;
            this.label2.Text = "Supprimer";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblajouter
            // 
            this.lblajouter.AutoSize = true;
            this.lblajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblajouter.Location = new System.Drawing.Point(87, 255);
            this.lblajouter.Name = "lblajouter";
            this.lblajouter.Size = new System.Drawing.Size(50, 16);
            this.lblajouter.TabIndex = 121;
            this.lblajouter.Text = "Ajouter";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 452);
            this.tabControl1.TabIndex = 134;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtnum);
            this.tabPage1.Controls.Add(this.lblajouter);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtpoid);
            this.tabPage1.Controls.Add(this.txtrecherche);
            this.tabPage1.Controls.Add(this.btnAjouter);
            this.tabPage1.Controls.Add(this.txtnom);
            this.tabPage1.Controls.Add(this.btnRecherche);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnNouveau);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnSupprimer);
            this.tabPage1.Controls.Add(this.grbdesignation);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnmodifier);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.hScrollBar1);
            this.tabPage2.Controls.Add(this.vScrollBar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Catalogue";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PicE);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(161, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 221);
            this.panel1.TabIndex = 142;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBar1.Location = new System.Drawing.Point(3, 3);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(781, 17);
            this.hScrollBar1.TabIndex = 141;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(784, 3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 420);
            this.vScrollBar1.TabIndex = 140;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::gestion_stock.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Add_item;
            this.btnAjouter.Location = new System.Drawing.Point(26, 244);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(55, 38);
            this.btnAjouter.TabIndex = 120;
            this.btnAjouter.Text = " ";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Image = global::gestion_stock.Properties.Resources.Iconleak_Atrous_Search;
            this.btnRecherche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecherche.Location = new System.Drawing.Point(644, 273);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(144, 38);
            this.btnRecherche.TabIndex = 130;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.AccessibleName = "";
            this.btnNouveau.Image = global::gestion_stock.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_New;
            this.btnNouveau.Location = new System.Drawing.Point(190, 244);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(55, 38);
            this.btnNouveau.TabIndex = 127;
            this.btnNouveau.Text = " ";
            this.btnNouveau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = global::gestion_stock.Properties.Resources.Custom_Icon_Design_Flatastic_4_Ticket_remove;
            this.btnSupprimer.Location = new System.Drawing.Point(188, 333);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(55, 38);
            this.btnSupprimer.TabIndex = 125;
            this.btnSupprimer.Text = " ";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Image = global::gestion_stock.Properties.Resources.Papirus_Team_Papirus_Status_Changes_prevent;
            this.btnmodifier.Location = new System.Drawing.Point(26, 333);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(55, 38);
            this.btnmodifier.TabIndex = 123;
            this.btnmodifier.Text = " ";
            this.btnmodifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // PicE
            // 
            this.PicE.Image = global::gestion_stock.Properties.Resources.computer;
            this.PicE.Location = new System.Drawing.Point(3, 0);
            this.PicE.Name = "PicE";
            this.PicE.Size = new System.Drawing.Size(344, 219);
            this.PicE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicE.TabIndex = 139;
            this.PicE.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::gestion_stock.Properties.Resources.hp;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 137;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestion_stock.Properties.Resources.lenovo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::gestion_stock.Properties.Resources.Harwen_Simple_RUN;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(825, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 38);
            this.button2.TabIndex = 131;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl2_produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Name = "UserControl2_produit";
            this.Size = new System.Drawing.Size(1029, 572);
            this.Load += new System.EventHandler(this.UserControl2_produit_Load);
            this.grbdesignation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtpoid;
        private System.Windows.Forms.GroupBox grbdesignation;
        private System.Windows.Forms.ComboBox cmbMesure;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label lblajouter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox PicE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}
