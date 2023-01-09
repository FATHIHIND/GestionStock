using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace gestion_stock
{
    public partial class UserControl2_achat : UserControl
    {
        private static UserControl2_achat _instance;
        public static UserControl2_achat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControl2_achat();

                }
                else
                    if (_instance != null)
                {
                    _instance = new UserControl2_achat();
                }
                return _instance;
            }
        }
        public UserControl2_achat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
        public static List<TEST> testt = new List<TEST>();
        private void btntest_Click(object sender, EventArgs e)
        {
            TEST fg = new TEST();
            fg.Prix_achat = txtpa.Text;
            fg.Quantité_achat = txtca.Text.ToString();
            fg.Fourniseur = cmbfourniseur.Text;
            fg.Designation = txtdesignation.Text;
            fg.Date = dtpdate.Value;
            testt.Add(fg);
            dgvtest.DataSource = null;
            dgvtest.DataSource = testt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clnInterface s = new clnInterface();
            s.ViderForm(this);
        }

        private void btnSerializer_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(testt.GetType());
            using (StreamWriter streamWriter = File.CreateText("test.xml"))
            {
                xmlSerializer.Serialize(streamWriter, testt);
            }
        }

        private void btnDeserializer_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(testt.GetType());
            using (StreamReader stream = File.OpenText("test.xml"))
            {
                testt = (List<TEST>)xmlSerializer.Deserialize(stream);
                dgvtest.DataSource = testt;
                // xmlSerializer.Deserialize(streeareader, TEST.f);
            }
        }

        private void UserControl2_achat_Load(object sender, EventArgs e)
        {
            cmbfourniseur.DataSource = fourniseur.c;
            cmbfourniseur.ValueMember = "numf";
            cmbfourniseur.DisplayMember = "Nomf";
        }

        private void achatBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvtest_DoubleClick(object sender, EventArgs e)
        {
            TEST f = new TEST();
            f.Prix_achat = dgvtest.CurrentRow.Cells[0].Value.ToString();
            f.Quantité_achat = dgvtest.CurrentRow.Cells[1].Value.ToString();
            f.Fourniseur = dgvtest.CurrentRow.Cells[2].Value.ToString();
            f.Designation = dgvtest.CurrentRow.Cells[3].Value.ToString();
            //-----
            txtpa.Text = f.Prix_achat.ToString();
            txtca.Text = f.Quantité_achat.ToString();
            cmbfourniseur.Text = f.Fourniseur;
            txtdesignation.Text = f.Designation;
        }

        private void txtpa_Leave(object sender, EventArgs e)
        {
            if (txtpa.Text == "")
            {
                txtpa.Text = "Prix_Achat";
                txtpa.ForeColor = Color.Silver;
            }
        }

        private void txtpa_Enter(object sender, EventArgs e)
        {
            if (txtpa.Text == "Prix_Achat")
            {
                txtpa.Text = "";
                txtpa.ForeColor = Color.Black;
            }
        }

        private void txtca_Leave(object sender, EventArgs e)
        {
            if (txtca.Text == "")
            {
                txtca.Text = "Quantité_Achat";
                txtca.ForeColor = Color.Silver;
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

        private void txtca_Enter(object sender, EventArgs e)
        {
            if (txtca.Text == "Quantité_Achat")
            {
                txtca.Text = "";
                txtca.ForeColor = Color.Black;
            }
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {

            Document b = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);



            PdfWriter v = PdfWriter.GetInstance(b, new FileStream("facture.pdf", FileMode.Create));
            b.Open();
            iTextSharp.text.Image gg = iTextSharp.text.Image.GetInstance("Bigstock.png");
            b.Add(gg);
            Paragraph c = new Paragraph("La Facture D'achat...\n");

            b.Add(c);

            PdfPTable sf = new PdfPTable(dgvtest.ColumnCount);
            for (int j = 0; j < dgvtest.ColumnCount; j++) 
            {
                sf.AddCell(new Phrase(dgvtest.Columns[j].HeaderText));
            }
            sf.HeaderRows = 1;
            for (int i = 0; i < dgvtest.Rows.Count; i++)
            {
                for (int f = 0; f < dgvtest.Columns.Count; f++)
                {
                    if (dgvtest[f, i].Value != null)
                    {
                        sf.AddCell(new Phrase(dgvtest[f, i].Value.ToString()));
                    }
                }
            }
            b.Add(sf);
            b.Close();
            System.Diagnostics.Process.Start("C:\\Users\\user\\source\\repos\\gestion_stock\\gestion_stock\\bin\\Debug\\facture.pdf");
        }
    }
}
