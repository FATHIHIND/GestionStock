using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_stock
{
 public   class triercs
    {
        private String numerop;
        private string nomp;
        private String poid;
        private String mesure;

        //  private String email;

        public String Numerop { get => numerop; set => numerop = value; }
        public string Nomp { get => nomp; set => nomp = value; }
        public String Poid { get => poid; set => poid = value; }
        public String Mesure { get => mesure; set => mesure = value; }

        //  public string Email { get => email; set => email = value; }
        public triercs() { }
        public triercs(String np, string nop, String pp, String mep, int Quantité_stock, int Contité_Rserve/*,String emp*/)
        {
            Numerop = np;
            nomp = nop;
            poid = pp;
            mesure = mep;

            //email = emp;
        }
        public bool ajouter()
        {
            if (trover(this) == false)
            {
                Data.gg.Add(this);
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool compare(triercs e, triercs b)
        {
            if (e.numerop == b.numerop)
            {
                return true;
            }
            else
            {
                if (e.nomp == b.nomp)
                {
                    return true;
                }
            }
            return false;
        }
        public bool trover(triercs c)
        {
#pragma warning disable CS0162 // Impossible d'atteindre le code détecté
            for (int i = 0; i < Data.gg.Count; i++)
#pragma warning restore CS0162 // Impossible d'atteindre le code détecté
            {
                if (compare(Data.gg[i], c) == true)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            return false;
        }
        public static List<triercs> rechercher(string nom)
        {
            List<triercs> x = new List<triercs>();
            foreach (triercs a in Data.gg)
            {
                if (a.Nomp.Length >= nom.Length) 
                {
                    if (a.Nomp.Substring(0, nom.Length).ToLower() == nom.ToLower())
                    {
                        x.Add(a);
                    }
                } 
            }
            return x; 
        } 
        public static List<triercs> rechercher_num(String num) 
        {
            List<triercs> x = new List<triercs>();
            foreach (triercs a in Data.gg)
            { 
                if (a.Numerop.Length >= num.Length)
                {
                    if (a.Numerop.Substring(0, num.Length)/*.ToLower() */== num/*.ToLower()*/) 
                    {
                        x.Add(a);
                    }
                }
            }
            return x;
        }
       

    }
}
