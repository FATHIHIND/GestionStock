using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_stock
{
  public  class vente
    {


        private String prix_Vente;
        private String quantite_Vente;
        private String designation;
        private DateTime date;
        private string clients ; 
        /* private Achats d;
         private produit f;*/
        // private fourniseur fourniseur;
        public vente() { }
        public vente(String p_vente, String q_vente, String desing,DateTime da,string cli/*,fourniseur four*/)
        { 
            Prix_Vente = p_vente;
            Quantite_Vente = q_vente;
            Designation = desing;
            Date = da;
            clients = cli;
            // Fourniseur = four;
        }
       
        //  public fourniseur Fourniseur { get => fourniseur; set => fourniseur = value; }

        public static List<vente> c = new List<vente>();
        public static List<vente> t = new List<vente>();

        public String Prix_Vente { get => prix_Vente; set => prix_Vente = value; }
        public String Quantite_Vente { get => quantite_Vente; set => quantite_Vente = value; }
        public string Clients { get => clients; set => clients = value; }
        public string Designation { get => designation; set => designation = value; }
        public DateTime Date { get => date; set => date = value; }
       

        public bool ajouter(vente A)
        {
            if (trouver(A.prix_Vente) == false)
            {
                c.Add(A);
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool trouver(String num)
        {
            foreach (vente a in c)
            {
                if (a.prix_Vente == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
