namespace gestion_stock
{
    partial class Aricle_Vente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grbdesignation = new System.Windows.Forms.GroupBox();
            this.cmbMesure = new System.Windows.Forms.ComboBox();
            this.grbcontié_acheter = new System.Windows.Forms.GroupBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.grbClient = new System.Windows.Forms.GroupBox();
            this.txtpoid = new System.Windows.Forms.TextBox();
            this.dgvpv = new System.Windows.Forms.DataGridView();
            this.txtnump = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbdesignation.SuspendLayout();
            this.grbcontié_acheter.SuspendLayout();
            this.grbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "NumP:";
            // 
            // grbdesignation
            // 
            this.grbdesignation.Controls.Add(this.cmbMesure);
            this.grbdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdesignation.Location = new System.Drawing.Point(75, 180);
            this.grbdesignation.Name = "grbdesignation";
            this.grbdesignation.Size = new System.Drawing.Size(255, 55);
            this.grbdesignation.TabIndex = 83;
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
            this.cmbMesure.TabIndex = 94;
            // 
            // grbcontié_acheter
            // 
            this.grbcontié_acheter.Controls.Add(this.txtnom);
            this.grbcontié_acheter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbcontié_acheter.Location = new System.Drawing.Point(75, 81);
            this.grbcontié_acheter.Name = "grbcontié_acheter";
            this.grbcontié_acheter.Size = new System.Drawing.Size(255, 55);
            this.grbcontié_acheter.TabIndex = 82;
            this.grbcontié_acheter.TabStop = false;
            this.grbcontié_acheter.Text = "Nom:";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(20, 23);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(229, 24);
            this.txtnom.TabIndex = 82;
            // 
            // grbClient
            // 
            this.grbClient.Controls.Add(this.txtpoid);
            this.grbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbClient.Location = new System.Drawing.Point(650, 180);
            this.grbClient.Name = "grbClient";
            this.grbClient.Size = new System.Drawing.Size(255, 55);
            this.grbClient.TabIndex = 81;
            this.grbClient.TabStop = false;
            this.grbClient.Text = "Quantité_Stock:";
            // 
            // txtpoid
            // 
            this.txtpoid.Location = new System.Drawing.Point(20, 23);
            this.txtpoid.Name = "txtpoid";
            this.txtpoid.Size = new System.Drawing.Size(229, 24);
            this.txtpoid.TabIndex = 82;
            this.txtpoid.TextChanged += new System.EventHandler(this.txtpoid_TextChanged);
            // 
            // dgvpv
            // 
            this.dgvpv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpv.Location = new System.Drawing.Point(47, 377);
            this.dgvpv.Name = "dgvpv";
            this.dgvpv.Size = new System.Drawing.Size(441, 150);
            this.dgvpv.TabIndex = 87;
            // 
            // txtnump
            // 
            this.txtnump.Location = new System.Drawing.Point(378, 30);
            this.txtnump.Name = "txtnump";
            this.txtnump.Size = new System.Drawing.Size(229, 20);
            this.txtnump.TabIndex = 86;
            this.txtnump.TextChanged += new System.EventHandler(this.txtnump_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::gestion_stock.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Add_item;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(670, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 85;
            this.button1.Text = "Ajouter";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::gestion_stock.Properties.Resources.Harwen_Simple_RUN;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(47, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 38);
            this.button2.TabIndex = 84;
            this.button2.Text = "Retour";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Aricle_Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(917, 583);
            this.Controls.Add(this.dgvpv);
            this.Controls.Add(this.txtnump);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grbdesignation);
            this.Controls.Add(this.grbcontié_acheter);
            this.Controls.Add(this.grbClient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Aricle_Vente";
            this.Text = "Produit_Vente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbdesignation.ResumeLayout(false);
            this.grbcontié_acheter.ResumeLayout(false);
            this.grbcontié_acheter.PerformLayout();
            this.grbClient.ResumeLayout(false);
            this.grbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbdesignation;
        private System.Windows.Forms.GroupBox grbcontié_acheter;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.GroupBox grbClient;
        private System.Windows.Forms.TextBox txtpoid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvpv;
        private System.Windows.Forms.TextBox txtnump;
        private System.Windows.Forms.ComboBox cmbMesure;
    }
}