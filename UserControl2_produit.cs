using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_stock
{
    public partial class UserControl2_produit : UserControl
    {
        private static UserControl2_produit _instance;
        public static UserControl2_produit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl2_produit();

                }
                else
                    if (_instance != null)
                {
                    _instance = new UserControl2_produit();
                }
                return _instance;
            }
        }

        public FormStartPosition StartPosition { get; private set; }

        public UserControl2_produit()
        { 
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void UserControl2_produit_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.StartPosition = FormStartPosition.CenterScreen; 
            hScrollBar1.Maximum = 850;
            hScrollBar1.Minimum = 0;
            hScrollBar1.Value = 0; 
            vScrollBar1.Maximum = 300;
            vScrollBar1.Minimum = 0;
            vScrollBar1.Value = 0;
            panel1.BackColor = Color.Blue;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            produit s = new produit();
            s.Numerop = int.Parse(txtnum.Text);
            s.Nomp = txtnom.Text;
            s.Poid = txtpoid.Text;
            s.Mesure = cmbMesure.Text;
            MessageBox.Show(s.ajouter().ToString(), "ajouter avec sucee".ToString());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Data.g;
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            produit s = new produit();
            s.Numerop = int.Parse(txtnum.Text);
            s.Nomp = txtnom.Text;
            s.Poid = txtpoid.Text;
            s.Mesure = cmbMesure.Text;
            MessageBox.Show(s.modifier(s, s).ToString(), "Modifier avec sucee".ToString());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Data.g;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            produit h = new produit();
            h.Numerop = int.Parse(txtnum.Text);
            h.Nomp = txtnom.Text;
            h.Poid = txtpoid.Text;
            h.Mesure = cmbMesure.Text;
            MessageBox.Show(h.supprimer(h).ToString(), "Supprimer avec sucee".ToString());
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Data.g;
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            clnInterface f = new clnInterface();
            f.ViderForm(this);
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            Boolean zak = false;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Selected = false;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (txtnom.Text.Equals(dataGridView1.Rows[i].Cells[1].Value))
                {

                    dataGridView1.Rows[i].Selected = true;
                    zak = true;
                }

            }
            if (zak == false) MessageBox.Show("Ereur");


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            produit f = new produit();
            f.Numerop = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            f.Nomp = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.Poid = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f.Mesure = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //-----
            txtnum.Text = f.Numerop.ToString();
            txtnom.Text = f.Nomp;
            txtpoid.Text = f.Poid.ToString();
            cmbMesure.Text = f.Mesure;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            produit d = new produit();
            if (d.Poid == 5.ToString())
            {
                dataGridView1.CurrentCell.Style.BackColor = Color.LightGreen;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentCell.Style.BackColor = Color.LightGreen;
        }

        private void txtnum_Leave(object sender, EventArgs e)
        {
            if (txtnum.Text == "")
            {
                txtnum.Text = "Numéro";
                txtnum.ForeColor = Color.Silver; 
            }
        }

        private void txtnum_Enter(object sender, EventArgs e)
        {
            if (txtnum.Text == "Numéro")
            {
                txtnum.Text = "";
                txtnum.ForeColor = Color.Black;
            }
        }

      
        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Nom";
                txtnom.ForeColor = Color.Silver;
            }
        }
        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text == "Nom")
            {
                txtnom.Text = "";
                txtnom.ForeColor = Color.Black;
            }
        }

        private void txtpoid_Leave(object sender, EventArgs e)
        {
            if (txtpoid.Text == "")
            {
                txtpoid.Text = "Poid";
                txtpoid.ForeColor = Color.Silver;
            }
        }

        private void txtpoid_Enter(object sender, EventArgs e)
        {
            if (txtpoid.Text == "Poid")
            {
                txtpoid.Text = "";
                txtpoid.ForeColor = Color.Black;
            }
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PicE.Visible == true)
            {
                PicE.Visible = false;
                pictureBox1.Visible = true;
            }
            else if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                PicE.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Location = new Point(hScrollBar1.Value, vScrollBar1.Value);

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            panel1.Location = new Point(hScrollBar1.Value, vScrollBar1.Value);
        }
    }
    }

