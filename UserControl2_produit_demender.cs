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
    public partial class UserControl2_produit_demender : UserControl
    {
        private static UserControl2_produit_demender _instance;
        public static UserControl2_produit_demender Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl2_produit_demender();

                }
                else
                    if (_instance != null)
                {
                    _instance = new UserControl2_produit_demender();
                }
                return _instance;
            }
        }
        public UserControl2_produit_demender()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void UserControl2_produit_demender_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void dtjsaisiedesdemandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuitterda_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterda_Click(object sender, EventArgs e)
        {

        }
    }
}
