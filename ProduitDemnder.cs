using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_stock
{
  public  class ProduitDemnder
    {
        private float qte_demender;
        private float qte_transformer;
        private bool accepter; 
        private DateTime dte;

        public static List<produit> a = new List<produit>();    
        public static List<DemendeAchat> od = new List<DemendeAchat>();
        public int num;
        /*Clientcombo x = new Clientcombo();
        Demende_Achat q = new Demende_Achat();*/
        //public float Qte_Demender;
        //public float Qte_Transformer;
        //public bool Accepter;
        //public DateTime Date_Prévu;
        public static List<ProduitDemnder> s = new List<ProduitDemnder>();

        public int Num { get; private set; }
        public float Qte_demender { get => qte_demender; set => qte_demender = value; }
        public float Qte_transformer { get => qte_transformer; set => qte_transformer = value; }
        public bool Accepter1 { get => accepter; set => accepter = value; }
        public DateTime Dte { get => dte; set => dte = value; }

        /*---ajouter_demende----*/
        public bool recherchRa(int num)
        {
            foreach (produit d in a)
            {
                if (d.Numerop == num)
                {
                    return true;
                }
            }
            return false; 
        }

        internal bool recherchRa(DataGridViewTextBoxColumn nom1)
        {
            foreach (produit d in a)
            {
                if (d.Numerop == num)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
