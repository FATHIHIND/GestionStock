using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_stock
{
   public class fourniseur
    {
        private int numf;
        private string nomf;
        private String telf;
        private string adressef;
        private String emailf;

        public int Numf { get => numf; set => numf = value; }
        public string Nomf { get => nomf; set => nomf = value; }
        public String Telf { get => telf; set => telf = value; }
        public string Adressef { get => adressef; set => adressef = value; }
        public String Emailf { get => emailf; set => emailf = value; }
        //private Achats f;
        public fourniseur() { }
        public fourniseur(int num, string nom, String email,string adresse,String tel)
        {
            numf = num;
            nomf = nom;
            emailf = email;
            adressef = adresse;
            telf = tel;
        }
        public static List<fourniseur> c = new List<fourniseur>();
        public static List<fourniseur> t = new List<fourniseur>();


        public bool ajouter(fourniseur A)
        {
            if (trouver(A.numf) == false)
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
            foreach (fourniseur a in c)
            {
                if (a.numf == num)
                {
                    return true;
                }
            }
            return false;
        }
        public int pos(int num)
        {
            int i;
            for (i = 0; i < c.Count; i++)
            {
                if (c[i].numf == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool modifier(fourniseur encien, fourniseur nouveau)
        {
            if (trouver(encien.numf) == true)
            {
                c[pos(encien.numf)] = nouveau;
                return true;

            }
            else
            {
                return false;
            }


        }
        public bool supprimer(fourniseur x)
        {
            if (trouver(x.numf) == true)
            {
                c.RemoveAt(pos(x.numf));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
