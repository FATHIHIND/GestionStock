namespace gestion_stock
{
    partial class UserControl2_achat
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
            this.grbFourniseur = new System.Windows.Forms.GroupBox();
            this.cmbfourniseur = new System.Windows.Forms.ComboBox();
            this.gbrdate = new System.Windows.Forms.GroupBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.txtpa = new System.Windows.Forms.TextBox();
            this.dgvtest = new System.Windows.Forms.DataGridView();
            this.txtca = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeserializer = new System.Windows.Forms.Button();
            this.btnSerializer = new System.Windows.Forms.Button();
            this.btntest = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.grbFourniseur.SuspendLayout();
            this.gbrdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtest)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFourniseur
            // 
            this.grbFourniseur.Controls.Add(this.cmbfourniseur);
            this.grbFourniseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFourniseur.Location = new System.Drawing.Point(283, 108);
            this.grbFourniseur.Name = "grbFourniseur";
            this.grbFourniseur.Size = new System.Drawing.Size(255, 65);
            this.grbFourniseur.TabIndex = 89;
            this.grbFourniseur.TabStop = false;
            this.grbFourniseur.Text = "Fourniseur";
            // 
            // cmbfourniseur
            // 
            this.cmbfourniseur.FormattingEnabled = true;
            this.cmbfourniseur.Location = new System.Drawing.Point(20, 23);
            this.cmbfourniseur.Name = "cmbfourniseur";
            this.cmbfourniseur.Size = new System.Drawing.Size(229, 26);
            this.cmbfourniseur.TabIndex = 68;
            // 
            // gbrdate
            // 
            this.gbrdate.Controls.Add(this.dtpdate);
            this.gbrdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrdate.Location = new System.Drawing.Point(283, 30);
            this.gbrdate.Name = "gbrdate";
            this.gbrdate.Size = new System.Drawing.Size(255, 65);
            this.gbrdate.TabIndex = 85;
            this.gbrdate.TabStop = false;
            this.gbrdate.Text = "Date";
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(20, 21);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(229, 24);
            this.dtpdate.TabIndex = 0;
            // 
            // txtdesignation
            // 
            this.txtdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesignation.Location = new System.Drawing.Point(23, 142);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(229, 31);
            this.txtdesignation.TabIndex = 0;
            this.txtdesignation.Enter += new System.EventHandler(this.txtdesignation_Enter);
            this.txtdesignation.Leave += new System.EventHandler(this.txtdesignation_Leave);
            // 
            // txtpa
            // 
            this.txtpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpa.Location = new System.Drawing.Point(23, 30);
            this.txtpa.Name = "txtpa";
            this.txtpa.Size = new System.Drawing.Size(229, 31);
            this.txtpa.TabIndex = 61;
            this.txtpa.Enter += new System.EventHandler(this.txtpa_Enter);
            this.txtpa.Leave += new System.EventHandler(this.txtpa_Leave);
            // 
            // dgvtest
            // 
            this.dgvtest.BackgroundColor = System.Drawing.Color.White;
            this.dgvtest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtest.Location = new System.Drawing.Point(13, 299);
            this.dgvtest.Name = "dgvtest";
            this.dgvtest.Size = new System.Drawing.Size(705, 197);
            this.dgvtest.TabIndex = 79;
            this.dgvtest.DoubleClick += new System.EventHandler(this.dgvtest_DoubleClick);
            // 
            // txtca
            // 
            this.txtca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtca.Location = new System.Drawing.Point(23, 85);
            this.txtca.Name = "txtca";
            this.txtca.Size = new System.Drawing.Size(229, 31);
            this.txtca.TabIndex = 61;
            this.txtca.Enter += new System.EventHandler(this.txtca_Enter);
            this.txtca.Leave += new System.EventHandler(this.txtca_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::gestion_stock.Properties.Resources.Harwen_Simple_RUN;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(822, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 40);
            this.button2.TabIndex = 87;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::gestion_stock.Properties.Resources.Custom_Icon_Design_Pretty_Office_9_New_file;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(579, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 88;
            this.button1.Text = "Nouveau";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeserializer
            // 
            this.btnDeserializer.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeserializer.Image = global::gestion_stock.Properties.Resources.Yellowlane_Winter_Game_Folder_Keep_Out_1;
            this.btnDeserializer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeserializer.Location = new System.Drawing.Point(416, 211);
            this.btnDeserializer.Name = "btnDeserializer";
            this.btnDeserializer.Size = new System.Drawing.Size(139, 36);
            this.btnDeserializer.TabIndex = 82;
            this.btnDeserializer.Text = "Conserver";
            this.btnDeserializer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeserializer.UseVisualStyleBackColor = true;
            this.btnDeserializer.Click += new System.EventHandler(this.btnDeserializer_Click);
            // 
            // btnSerializer
            // 
            this.btnSerializer.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerializer.Image = global::gestion_stock.Properties.Resources.Icojam_Blueberry_Basic_Record;
            this.btnSerializer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerializer.Location = new System.Drawing.Point(234, 212);
            this.btnSerializer.Name = "btnSerializer";
            this.btnSerializer.Size = new System.Drawing.Size(139, 36);
            this.btnSerializer.TabIndex = 81;
            this.btnSerializer.Text = "Enregistrer";
            this.btnSerializer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSerializer.UseVisualStyleBackColor = true;
            this.btnSerializer.Click += new System.EventHandler(this.btnSerializer_Click);
            // 
            // btntest
            // 
            this.btntest.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntest.Image = global::gestion_stock.Properties.Resources.Custom_Icon_Design_Flatastic_4_Package_add;
            this.btntest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntest.Location = new System.Drawing.Point(34, 211);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(139, 32);
            this.btntest.TabIndex = 80;
            this.btntest.Text = "ajouter";
            this.btntest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.Image = global::gestion_stock.Properties.Resources.Yellowlane_Winter_Game_Folder_Keep_Out;
            this.btnenregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenregistrer.Location = new System.Drawing.Point(602, 77);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(209, 39);
            this.btnenregistrer.TabIndex = 90;
            this.btnenregistrer.Text = "Observation Facture";
            this.btnenregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnenregistrer.UseVisualStyleBackColor = true;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // UserControl2_achat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.txtdesignation);
            this.Controls.Add(this.txtca);
            this.Controls.Add(this.txtpa);
            this.Controls.Add(this.grbFourniseur);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbrdate);
            this.Controls.Add(this.dgvtest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeserializer);
            this.Controls.Add(this.btnSerializer);
            this.Controls.Add(this.btntest);
            this.Name = "UserControl2_achat";
            this.Size = new System.Drawing.Size(1029, 572);
            this.Load += new System.EventHandler(this.UserControl2_achat_Load);
            this.grbFourniseur.ResumeLayout(false);
            this.gbrdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbFourniseur;
        private System.Windows.Forms.ComboBox cmbfourniseur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbrdate;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.TextBox txtpa;
        private System.Windows.Forms.DataGridView dgvtest;
        private System.Windows.Forms.Button btnDeserializer;
        private System.Windows.Forms.Button btnSerializer;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.TextBox txtca;
        private System.Windows.Forms.Button btnenregistrer;
    }
}
