namespace gestion_stock
{
    partial class UserControl2_vente
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
            this.dgvachat = new System.Windows.Forms.DataGridView();
            this.cmbclient = new System.Windows.Forms.ComboBox();
            this.grbClient = new System.Windows.Forms.GroupBox();
            this.txtca = new System.Windows.Forms.TextBox();
            this.txtpa = new System.Windows.Forms.TextBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.gbrdate = new System.Windows.Forms.GroupBox();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.lblajouter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.venteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvachat)).BeginInit();
            this.grbClient.SuspendLayout();
            this.gbrdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvachat
            // 
            this.dgvachat.BackgroundColor = System.Drawing.Color.White;
            this.dgvachat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvachat.Location = new System.Drawing.Point(23, 243);
            this.dgvachat.Name = "dgvachat";
            this.dgvachat.Size = new System.Drawing.Size(606, 243);
            this.dgvachat.TabIndex = 75;
            this.dgvachat.DoubleClick += new System.EventHandler(this.dgvachat_DoubleClick);
            // 
            // cmbclient
            // 
            this.cmbclient.FormattingEnabled = true;
            this.cmbclient.Location = new System.Drawing.Point(20, 24);
            this.cmbclient.Name = "cmbclient";
            this.cmbclient.Size = new System.Drawing.Size(229, 26);
            this.cmbclient.TabIndex = 0;
            // 
            // grbClient
            // 
            this.grbClient.Controls.Add(this.cmbclient);
            this.grbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbClient.Location = new System.Drawing.Point(327, 22);
            this.grbClient.Name = "grbClient";
            this.grbClient.Size = new System.Drawing.Size(255, 55);
            this.grbClient.TabIndex = 76;
            this.grbClient.TabStop = false;
            this.grbClient.Text = "Client";
            // 
            // txtca
            // 
            this.txtca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtca.Location = new System.Drawing.Point(29, 72);
            this.txtca.Name = "txtca";
            this.txtca.Size = new System.Drawing.Size(229, 31);
            this.txtca.TabIndex = 75;
            this.txtca.Enter += new System.EventHandler(this.txtca_Enter);
            this.txtca.Leave += new System.EventHandler(this.txtca_Leave);
            // 
            // txtpa
            // 
            this.txtpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpa.Location = new System.Drawing.Point(29, 26);
            this.txtpa.Name = "txtpa";
            this.txtpa.Size = new System.Drawing.Size(229, 31);
            this.txtpa.TabIndex = 75;
            this.txtpa.Enter += new System.EventHandler(this.txtpa_Enter);
            this.txtpa.Leave += new System.EventHandler(this.txtpa_Leave);
            // 
            // dtpdate
            // 
            this.dtpdate.Location = new System.Drawing.Point(20, 21);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(229, 24);
            this.dtpdate.TabIndex = 0;
            // 
            // gbrdate
            // 
            this.gbrdate.Controls.Add(this.dtpdate);
            this.gbrdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrdate.Location = new System.Drawing.Point(327, 83);
            this.gbrdate.Name = "gbrdate";
            this.gbrdate.Size = new System.Drawing.Size(255, 55);
            this.gbrdate.TabIndex = 79;
            this.gbrdate.TabStop = false;
            this.gbrdate.Text = "Date";
            // 
            // txtdesignation
            // 
            this.txtdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesignation.Location = new System.Drawing.Point(29, 120);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(229, 31);
            this.txtdesignation.TabIndex = 0;
            this.txtdesignation.Enter += new System.EventHandler(this.txtdesignation_Enter);
            this.txtdesignation.Leave += new System.EventHandler(this.txtdesignation_Leave);
            // 
            // lblajouter
            // 
            this.lblajouter.AutoSize = true;
            this.lblajouter.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblajouter.Location = new System.Drawing.Point(163, 183);
            this.lblajouter.Name = "lblajouter";
            this.lblajouter.Size = new System.Drawing.Size(164, 22);
            this.lblajouter.TabIndex = 83;
            this.lblajouter.Text = "Ajouter Au Facture";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::gestion_stock.Properties.Resources.Gakuseisean_Ivista_2_Misc_New_Database_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(670, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 86;
            this.button1.Text = "Nouveau";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::gestion_stock.Properties.Resources.Harwen_Simple_RUN;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(823, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 38);
            this.button2.TabIndex = 84;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::gestion_stock.Properties.Resources.Custom_Icon_Design_Flatastic_4_Add_item;
            this.btnAjouter.Location = new System.Drawing.Point(93, 177);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(55, 38);
            this.btnAjouter.TabIndex = 82;
            this.btnAjouter.Text = " ";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.Image = global::gestion_stock.Properties.Resources.Yellowlane_Winter_Game_Folder_Keep_Out;
            this.btnenregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenregistrer.Location = new System.Drawing.Point(357, 175);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(209, 39);
            this.btnenregistrer.TabIndex = 81;
            this.btnenregistrer.Text = "Observation Facture";
            this.btnenregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnenregistrer.UseVisualStyleBackColor = true;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // UserControl2_vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtdesignation);
            this.Controls.Add(this.txtca);
            this.Controls.Add(this.txtpa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvachat);
            this.Controls.Add(this.grbClient);
            this.Controls.Add(this.gbrdate);
            this.Controls.Add(this.lblajouter);
            this.Controls.Add(this.btnenregistrer);
            this.Name = "UserControl2_vente";
            this.Size = new System.Drawing.Size(1029, 572);
            this.Load += new System.EventHandler(this.UserControl2_vente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvachat)).EndInit();
            this.grbClient.ResumeLayout(false);
            this.gbrdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.venteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource venteBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvachat;
        private System.Windows.Forms.ComboBox cmbclient;
        private System.Windows.Forms.GroupBox grbClient;
        private System.Windows.Forms.TextBox txtca;
        private System.Windows.Forms.TextBox txtpa;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.GroupBox gbrdate;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label lblajouter;
        private System.Windows.Forms.Button btnenregistrer;
    }
}
