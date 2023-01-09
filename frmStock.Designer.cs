namespace gestion_stock
{
    partial class frmStock
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnjournal = new System.Windows.Forms.Button();
            this.btnjournal1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PicE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicE)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 67);
            this.button1.TabIndex = 13;
            this.button1.Text = "Article/Stock";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnjournal
            // 
            this.btnjournal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnjournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjournal.Location = new System.Drawing.Point(179, 444);
            this.btnjournal.Name = "btnjournal";
            this.btnjournal.Size = new System.Drawing.Size(197, 72);
            this.btnjournal.TabIndex = 14;
            this.btnjournal.Text = "Journale De Vente";
            this.btnjournal.UseVisualStyleBackColor = false;
            this.btnjournal.Click += new System.EventHandler(this.btnjournal_Click);
            // 
            // btnjournal1
            // 
            this.btnjournal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnjournal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjournal1.Location = new System.Drawing.Point(373, 463);
            this.btnjournal1.Name = "btnjournal1";
            this.btnjournal1.Size = new System.Drawing.Size(192, 75);
            this.btnjournal1.TabIndex = 15;
            this.btnjournal1.Text = "Journale D\'achat";
            this.btnjournal1.UseVisualStyleBackColor = false;
            this.btnjournal1.Click += new System.EventHandler(this.btnjournal1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::gestion_stock.Properties.Resources.Harwen_Simple_RUN;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(708, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 61;
            this.button2.Text = "Retour";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PicE
            // 
            this.PicE.Image = global::gestion_stock.Properties.Resources.stock1;
            this.PicE.Location = new System.Drawing.Point(2, 2);
            this.PicE.Name = "PicE";
            this.PicE.Size = new System.Drawing.Size(849, 546);
            this.PicE.TabIndex = 12;
            this.PicE.TabStop = false;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnjournal1);
            this.Controls.Add(this.btnjournal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PicE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmStock";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.PicE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnjournal;
        private System.Windows.Forms.Button btnjournal1;
        private System.Windows.Forms.Button button2;
    }
}