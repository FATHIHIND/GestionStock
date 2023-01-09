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
    public partial class Trier_rechercher : UserControl
    {


        private static Trier_rechercher _instance;
        public static Trier_rechercher Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Trier_rechercher();

                }
                else
                    if (_instance != null)
                {
                    _instance = new Trier_rechercher();
                }
                return _instance;
            }
        }


        public Trier_rechercher()
        { 
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Trier_rechercher_Load(object sender, EventArgs e)
        {
            Data.Dserialiserclsproduit();
            dgvclsproduit.DataSource = null;
            dgvclsproduit.DataSource = Data.gg;
        }

        private void btnAjouterda_Click(object sender, EventArgs e)
        {
            triercs w = new triercs();
            w.Numerop =txtrnum.Text;
            w.Nomp = txtrnom.Text;
            w.Poid = txtrpoid.Text;
            w.Mesure = cmbrMesure.Text;
            MessageBox.Show(w.ajouter().ToString(), "ajouter avec sucee".ToString());
            dgvclsproduit.DataSource = null;
            dgvclsproduit.DataSource = Data.gg;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dgvclsproduit.DataSource = null;
            dgvclsproduit.DataSource = triercs.rechercher(txtrnom.Text);
        }

        private void Trier_rechercher_VisibleChanged(object sender, EventArgs e)
        {
          
        }

        private void Trier_rechercher_LocationChanged(object sender, EventArgs e)
        {
            
        }

        private void Trier_rechercher_Move(object sender, EventArgs e)
        {
            
        }
        private void J_FormClosing(object sender, FormClosingEventArgs e)
        {
            Data.serialiserclsproduit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void txtrnum_Leave(object sender, EventArgs e)
        {
            if (txtrnum.Text == "")
            {
                txtrnum.Text = "Numéro";
                txtrnum.ForeColor = Color.Silver;
            }
        }

        private void txtrnum_Enter(object sender, EventArgs e)
        {
            if (txtrnum.Text == "Numéro")
            {
                txtrnum.Text = "";
                txtrnum.ForeColor = Color.Black;
            }
        }

        private void txtrnom_Leave(object sender, EventArgs e)
        {
            if (txtrnom.Text == "")
            {
                txtrnom.Text = "Nom";
                txtrnom.ForeColor = Color.Silver;
            }
        }

        private void txtrnom_Enter(object sender, EventArgs e)
        {
            if (txtrnom.Text == "Nom")
            {
                txtrnom.Text = "";
                txtrnom.ForeColor = Color.Black;
            }
        }

        private void txtrpoid_Leave(object sender, EventArgs e)
        {
            if (txtrpoid.Text == "")
            {
                txtrpoid.Text = "Poid";
                txtrpoid.ForeColor = Color.Silver;
            }
        }

        private void txtrpoid_Enter(object sender, EventArgs e)
        {
            if (txtrpoid.Text == "Poid")
            {
                txtrpoid.Text = "";
                txtrpoid.ForeColor = Color.Black;
            }
        }
    }
}
