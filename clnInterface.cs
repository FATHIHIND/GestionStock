using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_stock
{
    class clnInterface
    {
        public void ViderForm(Control f) 
        {
            foreach (Control ctl in f.Controls)
            {
                if (ctl.Controls.Count > 0)
                {
                    ViderForm(ctl);  
                }
                if (ctl.GetType() == typeof(TextBox))
                {
                    ctl.Text = "";
                }
                if (ctl.GetType() == typeof(RadioButton))
                {
                    ((RadioButton)ctl).Checked = false;
                }
                if (ctl.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)ctl).Value = DateTime.Now;
                }
                if (ctl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctl).Text = "";
                }
                if (ctl.GetType() == typeof(ListBox))
                {

                    ((ListBox)ctl).SelectedItems.Clear();
                }
                if (ctl.GetType() == typeof(RichTextBox))
                {

                    ((RichTextBox)ctl).Text = "";
                }
                if (ctl.GetType() == typeof(MaskedTextBox))
                {

                    ((MaskedTextBox)ctl).Text = "";
                }
                if (ctl.GetType() == typeof(CheckBox))
                {

                    ((CheckBox)ctl).Checked =false;
                }
            }
        }
        //------------trouve------

        public bool trove(DataGridView Dg, string cham, object Value)

        {

            int j;

            for (j = 0; j < Dg.Rows.Count; j++)
            {

                if (Value == Dg.Rows[j].Cells["Numero"].Value)
                {
                    return true;
                }

            }
            return false;
        }
        //------------retourne l'indice de l'element recherché------

        public int troveIindice(DataGridView Dg, string cham, object Value)

        {

            int j;
            for (j = 0; j < Dg.Rows.Count; j++)
            {

                if (Value.ToString() == (string)Dg.Rows[j].Cells["Numero"].Value)
                {
                    return j;
                }

            }
            return -1;
        }
        //---------
        //------------------------VERIFIER VIDE---------------------
        public void VérifierVide(Control f)
        {
            foreach (Control ctl in f.Controls)
            {

                if (ctl.GetType() == typeof(TextBox))
                {
                    ctl.Text = "";
                    string nomctl;
                    nomctl = ctl.Name.Substring(3);
                    foreach (Control ctl2 in f.Controls)
                    {

                        if (ctl2.GetType() == typeof(Label))
                        {
                            if (ctl2.Name.Substring(3) == nomctl)
                            {
                                if (ctl2.Font.Underline == true)
                                {

                                    MessageBox.Show("la zone est obligatiore", ctl2.Text + "EREUR", MessageBoxButtons.OK);
                                    ctl.Focus();
                                    return;
                                }
                            }
                        }
                    }
                }

                if (ctl.Controls.Count > 0)
                {
                    VérifierVide(ctl);
                }
            }

        }

    }
}
