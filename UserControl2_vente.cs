using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace gestion_stock
{
    public partial class UserControl2_vente : UserControl
    {
        private static UserControl2_vente _instance;
        public static UserControl2_vente Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl2_vente();

                }
                else
                    if (_instance != null)
                {
                    _instance = new UserControl2_vente();
                }
                return _instance;
            }
        }
        public UserControl2_vente()
        {
            InitializeComponent();
        }

        private void UserControl2_vente_Load(object sender, EventArgs e)
        {
            cmbclient.DataSource = client.c;
            cmbclient.ValueMember = "Numc";
            cmbclient.DisplayMember = "Nomc";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose(); 
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            vente s = new vente();
            s.Prix_Vente = txtpa.Text;
            s.Quantite_Vente = txtca.Text;
            s.Clients = cmbclient.Text;
            s.Designation = txtdesignation.Text.ToString();
            s.Date = dtpdate.Value;



            if (s.ajouter(s) == true)
            {
                MessageBox.Show("Vente Ajouter Avec Succes");
                dgvachat.DataSource = null;
                dgvachat.DataSource = vente.c;
            }
            else
            {
                MessageBox.Show("Vente n'A Pas Ajouter ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clnInterface s = new clnInterface();
            s.ViderForm(this);
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            Document b = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);



            PdfWriter v = PdfWriter.GetInstance(b, new FileStream("facture.pdf", FileMode.Create));
            b.Open();
            iTextSharp.text.Image gg = iTextSharp.text.Image.GetInstance("Bigstock.png");
            b.Add(gg);
            Paragraph c = new Paragraph("La Facture De Vente...\n");

            b.Add(c);

            PdfPTable sf = new PdfPTable(dgvachat.ColumnCount);
            for (int j = 0; j < dgvachat.ColumnCount; j++)
            {
                sf.AddCell(new Phrase(dgvachat.Columns[j].HeaderText));
            }
            sf.HeaderRows = 1;
            for (int i = 0; i < dgvachat.Rows.Count; i++)
            {
                for (int f = 0; f < dgvachat.Columns.Count; f++)
                {
                    if (dgvachat[f, i].Value != null)
                    {
                        sf.AddCell(new Phrase(dgvachat[f, i].Value.ToString()));
                    }
                }
            }
            b.Add(sf);
            b.Close();
            System.Diagnostics.Process.Start("C:\\Users\\user\\source\\repos\\gestion_stock\\gestion_stock\\bin\\Debug\\facture.pdf");
        }

        private void dgvachat_DoubleClick(object sender, EventArgs e)
        {
            vente f = new vente();
            f.Prix_Vente = dgvachat.CurrentRow.Cells[0].Value.ToString();
            f.Quantite_Vente = dgvachat.CurrentRow.Cells[1].Value.ToString();
            f.Clients = dgvachat.CurrentRow.Cells[2].Value.ToString();
            f.Designation = dgvachat.CurrentRow.Cells[3].Value.ToString();
            //-----
            txtpa.Text = f.Prix_Vente.ToString();
            txtca.Text = f.Quantite_Vente.ToString();
            cmbclient.Text = f.Clients;
            txtdesignation.Text = f.Designation;
        }

        private void txtpa_Leave(object sender, EventArgs e)
        {
            if (txtpa.Text == "")
            {
                txtpa.Text = "Prix_Vente";
                txtpa.ForeColor = Color.Silver;
            }
        }

        private void txtpa_Enter(object sender, EventArgs e)
        {
            if (txtpa.Text == "Prix_Vente")
            {
                txtpa.Text = "";
                txtpa.ForeColor = Color.Black;
            }
        }

        private void txtca_Leave(object sender, EventArgs e)
        {
            if (txtca.Text == "")
            {
                txtca.Text = "Quantité_Vente";
                txtca.ForeColor = Color.Silver;
            }
        }

        private void txtca_Enter(object sender, EventArgs e)
        {
            if (txtca.Text == "Quantité_Vente")
            {
                txtca.Text = "";
                txtca.ForeColor = Color.Black;
            }
        }

        private void txtdesignation_Leave(object sender, EventArgs e)
        {

            if (txtdesignation.Text == "")
            {
                txtdesignation.Text = "Designation";
                txtdesignation.ForeColor = Color.Silver;
            }
        }

        private void txtdesignation_Enter(object sender, EventArgs e)
        {
            if (txtdesignation.Text == "Designation")
            {
                txtdesignation.Text = "";
                txtdesignation.ForeColor = Color.Black;
            }
        }
    }
}
