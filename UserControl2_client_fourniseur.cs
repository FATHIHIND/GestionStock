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
    public partial class UserControl2_client_fourniseur : UserControl
    {
        private static UserControl2_client_fourniseur _instance;
        public static UserControl2_client_fourniseur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl2_client_fourniseur();

                }
                else
                    if (_instance != null)
                {
                    _instance = new UserControl2_client_fourniseur();
                }
                return _instance;
            }
        }
        public UserControl2_client_fourniseur()
        {
            InitializeComponent();
        }

        private void UserControl2_client_fourniseur_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (rdbClient.Checked == true)
            {
                client s = new client();
                s.Numc = int.Parse(textBox1.Text);
                s.Nomc = txtnom.Text;
                s.Adresse = txtadresse.Text;
                s.Telc = txtTel.Text;
                s.Email = txtEmail.Text;
                if (s.ajouter(s) == true)
                {
                    MessageBox.Show("Ajouter Avec Succes");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = client.c;
                }
                else
                {
                    MessageBox.Show("Imposible de répeter le même numero ");
                }

            }



            if (rdbFourniseur.Checked == true)
            {
                fourniseur D = new fourniseur();
                D.Numf = int.Parse(textBox1.Text);
                D.Nomf = txtnom.Text;
                D.Adressef = txtadresse.Text;
                D.Telf = txtTel.Text;
                D.Emailf = txtEmail.Text;
                if (D.ajouter(D) == true)
                {
                    MessageBox.Show("Ajouter Avec Succes");
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = fourniseur.c;
                }
                else
                {
                    MessageBox.Show("n'A Pas Ajouter ");
                }
            }
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            if (rdbClient.Checked == true)
            {
                client s = new client();
                s.Numc = int.Parse(textBox1.Text);
                s.Nomc = txtnom.Text;
                s.Adresse = txtadresse.Text;
                s.Telc = txtTel.Text;
                s.Email = txtEmail.Text;
                client z = new client();
                z.Numc = int.Parse(textBox1.Text);
                z.Nomc = txtnom.Text;
                z.Adresse = txtadresse.Text;
                z.Telc = txtTel.Text;
                z.Email = txtEmail.Text;
                if (z.modifier(z, s))
                {
                    MessageBox.Show(" Modifier Avec Succes");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = client.c;
                }
                else
                {
                    MessageBox.Show(" champ obligatoire:Imposible de le modifier ");
                }
            }



            if (rdbFourniseur.Checked == true)
            {
                fourniseur D = new fourniseur();
                D.Numf = int.Parse(textBox1.Text);
                D.Nomf = txtnom.Text;
                D.Adressef = txtadresse.Text;
                D.Telf = txtTel.Text;
                D.Emailf = txtEmail.Text;
                fourniseur v = new fourniseur();
                v.Numf = int.Parse(textBox1.Text);
                v.Nomf = txtnom.Text;
                v.Adressef = txtadresse.Text;
                v.Telf = txtTel.Text;
                v.Emailf = txtEmail.Text;
                if (v.modifier(v, D))
                {
                    MessageBox.Show(" Modifier Avec Succes");
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = fourniseur.c;
                }
                else
                {
                    MessageBox.Show(" n'A Pas Modifier ");
                }


            }

        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            if (rdbClient.Checked == true)
            {
                client s = new client();
                s.Numc = int.Parse(textBox1.Text);
                s.Nomc = txtnom.Text;
                s.Adresse = txtadresse.Text;
                s.Telc = txtTel.Text;
                s.Email = txtEmail.Text;
                if (s.supprimer(s) == true)
                {
                    MessageBox.Show(" supprimer Avec Succes");
                }
                else
                {
                    MessageBox.Show(" n'A Pas supprimer ");
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = client.c;

            }



            if (rdbFourniseur.Checked == true)
            {
                fourniseur D = new fourniseur();
                D.Numf = int.Parse(textBox1.Text);
                D.Nomf = txtnom.Text;
                D.Adressef = txtadresse.Text;
                D.Telf = txtTel.Text;
                D.Emailf = txtEmail.Text;
                if (D.supprimer(D) == true)
                {
                    MessageBox.Show(" supprimer Avec Succes");
                }
                else
                {
                    MessageBox.Show("n'A Pas supprimer ");
                }
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = fourniseur.c;
            }


        }

        private void btnnouveau_Click(object sender, EventArgs e)
        {
            clnInterface s = new clnInterface();
            s.ViderForm(this);
        }

        private void dgvclient_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dgvclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFourniseur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFourniseur_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            fourniseur d = new fourniseur();
            d.Numf = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            d.Nomf = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            d.Telf = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            d.Adressef = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            d.Emailf = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = d.Numf.ToString();
            txtnom.Text = d.Nomf;
            txtTel.Text = d.Telf.ToString();
            txtadresse.Text = d.Adressef;
            txtEmail.Text = d.Emailf;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            client f = new client();
            f.Numc = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            f.Nomc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.Telc = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.Adresse = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f.Email = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //-----
            textBox1.Text = f.Numc.ToString();
            txtnom.Text = f.Nomc;
            txtTel.Text = f.Telc.ToString();
            txtadresse.Text = f.Adresse;
            txtEmail.Text = f.Email;
        }

       
     

       

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Numéro";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Numéro")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void txtnom_Leave_1(object sender, EventArgs e)
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

      

        private void txtTel_Leave_1(object sender, EventArgs e)
        {

            if (txtTel.Text == "")
            {
                txtTel.Text = "Télephone";
                txtTel.ForeColor = Color.Silver;
            }
        }

        private void txtadresse_Leave(object sender, EventArgs e)
        {
            if (txtadresse.Text == "")
            {
                txtadresse.Text = "Adresse";
                txtadresse.ForeColor = Color.Silver;
            }
        }

        private void txtadresse_Enter(object sender, EventArgs e)
        {
            if (txtadresse.Text == "Adresse")
            {
                txtadresse.Text = "";
                txtadresse.ForeColor = Color.Black;
            }
        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            if (txtTel.Text == "Télephone")
            {
                txtTel.Text = "";
                txtTel.ForeColor = Color.Black;
            }
        }
    }


    }