namespace gestion_stock
{
    partial class UserControl2_client_fourniseur
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
            this.rdbFourniseur = new System.Windows.Forms.RadioButton();
            this.rdbClient = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lbllistefourniseur = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnnouveau = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsupp = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.PicE = new System.Windows.Forms.PictureBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicE)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbFourniseur
            // 
            this.rdbFourniseur.AutoSize = true;
            this.rdbFourniseur.Location = new System.Drawing.Point(358, 312);
            this.rdbFourniseur.Name = "rdbFourniseur";
            this.rdbFourniseur.Size = new System.Drawing.Size(74, 17);
            this.rdbFourniseur.TabIndex = 80;
            this.rdbFourniseur.TabStop = true;
            this.rdbFourniseur.Text = "Fourniseur";
            this.rdbFourniseur.UseVisualStyleBackColor = true;
            // 
            // rdbClient
            // 
            this.rdbClient.AutoSize = true;
            this.rdbClient.Location = new System.Drawing.Point(291, 312);
            this.rdbClient.Name = "rdbClient";
            this.rdbClient.Size = new System.Drawing.Size(51, 17);
            this.rdbClient.TabIndex = 79;
            this.rdbClient.TabStop = true;
            this.rdbClient.Text = "Client";
            this.rdbClient.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "Liste Client";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(13, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(346, 31);
            this.txtEmail.TabIndex = 76;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtadresse
            // 
            this.txtadresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadresse.Location = new System.Drawing.Point(13, 242);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(346, 31);
            this.txtadresse.TabIndex = 74;
            this.txtadresse.Enter += new System.EventHandler(this.txtadresse_Enter);
            this.txtadresse.Leave += new System.EventHandler(this.txtadresse_Leave);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(13, 184);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(346, 31);
            this.txtTel.TabIndex = 71;
            this.txtTel.Enter += new System.EventHandler(this.txtTel_Enter);
            this.txtTel.Leave += new System.EventHandler(this.txtTel_Leave_1);
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(13, 60);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(346, 31);
            this.txtnom.TabIndex = 70;
            this.txtnom.Enter += new System.EventHandler(this.txtnom_Enter);
            this.txtnom.Leave += new System.EventHandler(this.txtnom_Leave_1);
            // 
            // lbllistefourniseur
            // 
            this.lbllistefourniseur.AutoSize = true;
            this.lbllistefourniseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistefourniseur.Location = new System.Drawing.Point(458, 340);
            this.lbllistefourniseur.Name = "lbllistefourniseur";
            this.lbllistefourniseur.Size = new System.Drawing.Size(150, 24);
            this.lbllistefourniseur.TabIndex = 69;
            this.lbllistefourniseur.Text = "Liste Fourniseur:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(432, 376);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(432, 146);
            this.dataGridView2.TabIndex = 86;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 31);
            this.textBox1.TabIndex = 87;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 146);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnnouveau
            // 
            this.btnnouveau.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnouveau.Image = global::gestion_stock.Properties.Resources.Gakuseisean_Ivista_2_Misc_New_Database;
            this.btnnouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnouveau.Location = new System.Drawing.Point(432, 253);
            this.btnnouveau.Name = "btnnouveau";
            this.btnnouveau.Size = new System.Drawing.Size(132, 38);
            this.btnnouveau.TabIndex = 84;
            this.btnnouveau.Text = "Nouveau";
            this.btnnouveau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnouveau.UseVisualStyleBackColor = true;
            this.btnnouveau.Click += new System.EventHandler(this.btnnouveau_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::gestion_stock.Properties.Resources.Harwen_Simple_RUN;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(822, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 38);
            this.button2.TabIndex = 83;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsupp
            // 
            this.btnsupp.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.Image = global::gestion_stock.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_list_remove_user;
            this.btnsupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupp.Location = new System.Drawing.Point(686, 253);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(132, 38);
            this.btnsupp.TabIndex = 82;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsupp.UseVisualStyleBackColor = true;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // btnmodif
            // 
            this.btnmodif.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodif.Image = global::gestion_stock.Properties.Resources.Icons8_Windows_8_Users_Change_User;
            this.btnmodif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodif.Location = new System.Drawing.Point(686, 177);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(132, 38);
            this.btnmodif.TabIndex = 81;
            this.btnmodif.Text = "Modifier";
            this.btnmodif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmodif.UseVisualStyleBackColor = true;
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // PicE
            // 
            this.PicE.Image = global::gestion_stock.Properties.Resources.client;
            this.PicE.Location = new System.Drawing.Point(523, 23);
            this.PicE.Name = "PicE";
            this.PicE.Size = new System.Drawing.Size(207, 132);
            this.PicE.TabIndex = 77;
            this.PicE.TabStop = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Image = global::gestion_stock.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_contact_new;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(432, 182);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(132, 38);
            this.btnAjouter.TabIndex = 68;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // UserControl2_client_fourniseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnnouveau);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.rdbFourniseur);
            this.Controls.Add(this.rdbClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PicE);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lbllistefourniseur);
            this.Controls.Add(this.btnAjouter);
            this.Name = "UserControl2_client_fourniseur";
            this.Size = new System.Drawing.Size(1029, 572);
            this.Load += new System.EventHandler(this.UserControl2_client_fourniseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnouveau;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.RadioButton rdbFourniseur;
        private System.Windows.Forms.RadioButton rdbClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicE;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.TextBox txtNuméro;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label lbllistefourniseur;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
