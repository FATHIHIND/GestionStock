using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_stock
{
   public class VenteS
    {
      private int  nump;
        private string nom;
        private String mesure;
       
        private int quantité;

        public int Nump { get => nump; set => nump = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Quantité { get => quantité; set => quantité = value; }
        public string Mesure { get => mesure; set => mesure = value; }
        
        public VenteS() { }
        public VenteS(int num,string no,String mesu,int qua)
        {
            nump=num;
            nom = no;
            Mesure = mesu;
            quantité = qua;
            
        }
        public static List<VenteS> c = new List<VenteS>();
        public static List<VenteS> t = new List<VenteS>();


        public bool ajouter(VenteS A)
        {
            if (trouver(A.nump) == false)
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
            foreach (VenteS a in c)
            {
                if (a.nump == num)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
