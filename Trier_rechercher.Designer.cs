namespace gestion_stock
{
    partial class Trier_rechercher
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
            this.dgvclsproduit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAjouterda = new System.Windows.Forms.Button();
            this.cmbrMesure = new System.Windows.Forms.ComboBox();
            this.grbdesignation = new System.Windows.Forms.GroupBox();
            this.txtrnum = new System.Windows.Forms.TextBox();
            this.txtrpoid = new System.Windows.Forms.TextBox();
            this.txtrnom = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclsproduit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbdesignation.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvclsproduit
            // 
            this.dgvclsproduit.BackgroundColor = System.Drawing.Color.White;
            this.dgvclsproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclsproduit.Location = new System.Drawing.Point(6, 112);
            this.dgvclsproduit.Name = "dgvclsproduit";
            this.dgvclsproduit.Size = new System.Drawing.Size(778, 385);
            this.dgvclsproduit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(585, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvclsproduit);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rechercher_Trier";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAjouterda
            // 
            this.btnAjouterda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterda.Location = new System.Drawing.Point(72, 340);
            this.btnAjouterda.Name = "btnAjouterda";
            this.btnAjouterda.Size = new System.Drawing.Size(131, 37);
            this.btnAjouterda.TabIndex = 89;
            this.btnAjouterda.Text = "Ajouter";
            this.btnAjouterda.UseVisualStyleBackColor = true;
            this.btnAjouterda.Click += new System.EventHandler(this.btnAjouterda_Click);
            // 
            // cmbrMesure
            // 
            this.cmbrMesure.FormattingEnabled = true;
            this.cmbrMesure.Items.AddRange(new object[] {
            "Piece",
            "Litre",
            "Killo"});
            this.cmbrMesure.Location = new System.Drawing.Point(20, 23);
            this.cmbrMesure.Name = "cmbrMesure";
            this.cmbrMesure.Size = new System.Drawing.Size(229, 26);
            this.cmbrMesure.TabIndex = 93;
            // 
            // grbdesignation
            // 
            this.grbdesignation.Controls.Add(this.cmbrMesure);
            this.grbdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdesignation.Location = new System.Drawing.Point(20, 258);
            this.grbdesignation.Name = "grbdesignation";
            this.grbdesignation.Size = new System.Drawing.Size(255, 55);
            this.grbdesignation.TabIndex = 88;
            this.grbdesignation.TabStop = false;
            this.grbdesignation.Text = "Mesure:";
            // 
            // txtrnum
            // 
            this.txtrnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrnum.Location = new System.Drawing.Point(20, 32);
            this.txtrnum.Name = "txtrnum";
            this.txtrnum.Size = new System.Drawing.Size(229, 31);
            this.txtrnum.TabIndex = 82;
            this.txtrnum.Enter += new System.EventHandler(this.txtrnum_Enter);
            this.txtrnum.Leave += new System.EventHandler(this.txtrnum_Leave);
            // 
            // txtrpoid
            // 
            this.txtrpoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrpoid.Location = new System.Drawing.Point(20, 157);
            this.txtrpoid.Name = "txtrpoid";
            this.txtrpoid.Size = new System.Drawing.Size(229, 31);
            this.txtrpoid.TabIndex = 82;
            this.txtrpoid.Enter += new System.EventHandler(this.txtrpoid_Enter);
            this.txtrpoid.Leave += new System.EventHandler(this.txtrpoid_Leave);
            // 
            // txtrnom
            // 
            this.txtrnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrnom.Location = new System.Drawing.Point(20, 81);
            this.txtrnom.Name = "txtrnom";
            this.txtrnom.Size = new System.Drawing.Size(229, 31);
            this.txtrnom.TabIndex = 82;
            this.txtrnom.Enter += new System.EventHandler(this.txtrnom_Enter);
            this.txtrnom.Leave += new System.EventHandler(this.txtrnom_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txtrpoid);
            this.tabPage2.Controls.Add(this.txtrnom);
            this.tabPage2.Controls.Add(this.txtrnum);
            this.tabPage2.Controls.Add(this.btnAjouterda);
            this.tabPage2.Controls.Add(this.grbdesignation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saisir des Demende_Achats";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 526);
            this.tabControl1.TabIndex = 4;
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
            this.button2.TabIndex = 132;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Trier_rechercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Trier_rechercher";
            this.Size = new System.Drawing.Size(1029, 572);
            this.Load += new System.EventHandler(this.Trier_rechercher_Load);
            this.LocationChanged += new System.EventHandler(this.Trier_rechercher_LocationChanged);
            this.VisibleChanged += new System.EventHandler(this.Trier_rechercher_VisibleChanged);
            this.Move += new System.EventHandler(this.Trier_rechercher_Move);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclsproduit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.grbdesignation.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvclsproduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAjouterda;
        private System.Windows.Forms.ComboBox cmbrMesure;
        private System.Windows.Forms.GroupBox grbdesignation;
        private System.Windows.Forms.TextBox txtrnum;
        private System.Windows.Forms.TextBox txtrpoid;
        private System.Windows.Forms.TextBox txtrnom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button2;
    }
}
