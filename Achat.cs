using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
namespace gestion_stock
{
  public  class Achat
    {

        private int prix_Achat;
        private int quantite_Achat;
        private String designation;
        private DateTime date;
        private string fourniseur;

        /* private Achats d;
         private produit f;*/
        // private fourniseur fourniseur;
        public Achat() { }
        public Achat(int p_Achat, int q_Achat, String desing,DateTime dat,string fou/*,fourniseur four*/)
        {
            prix_Achat = p_Achat;
            quantite_Achat = q_Achat;
             date = dat;
            fourniseur = fou;
        }

        //  public fourniseur Fourniseur { get => fourniseur; set => fourniseur = value; }

        public static List<Achat> c = new List<Achat>();
        public static List<Achat> t = new List<Achat>();

        public int Prix_Achat { get => prix_Achat; set => prix_Achat = value; }
        public int Quantite_Achat  { get => quantite_Achat; set => quantite_Achat = value; }
        public string Designation { get => designation; set => designation = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Fourniseur { get => fourniseur; set => fourniseur = value; }

        public bool ajouter(Achat A)
        {
            if (trouver(A.prix_Achat) == false)
            {
                c.Add(A);
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool trouver(int num)
        {
            foreach (Achat a in c)
            {
                if (a.prix_Achat == num)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<Achat> b = new List<Achat>();
        public void serialize_deserialise()
        {
             XmlSerializer xmlSerializer = new XmlSerializer(b.GetType());
            using (StreamWriter streamWriter = File.CreateText("test.xml"))
            {
                xmlSerializer.Serialize(streamWriter, b);
            }
           

        }
    }
}
