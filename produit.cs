using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_stock
{
   public class produit
    {
        private int numerop;
        private string nomp;
        private String poid;
        private String mesure;
       
      //  private String email;

        public int Numerop { get => numerop; set => numerop = value; } 
        public string Nomp { get => nomp; set => nomp = value; } 
        public String Poid { get => poid; set => poid = value; }
        public String Mesure { get => mesure; set => mesure = value; }
      
        //  public string Email { get => email; set => email = value; }
        public produit() { }
        public produit(int np, string nop, String pp, String mep, int Quantité_stock, int Contité_Rserve/*,String emp*/)
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
                Data.g.Add(this);
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool compare(produit e, produit b)
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
        public bool trover(produit c)
        {
#pragma warning disable CS0162 // Impossible d'atteindre le code détecté
            for (int i = 0; i < Data.g.Count; i++)
#pragma warning restore CS0162 // Impossible d'atteindre le code détecté
            {
                if (compare(Data.g[i], c) == true)
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
        public bool modifier(produit olda, produit newa)
        {
            if (compare(olda, newa) == true)
            {
#pragma warning disable CS0162 // Impossible d'atteindre le code détecté
                for (int i = 0; i < Data.g.Count;i++)
#pragma warning restore CS0162 // Impossible d'atteindre le code détecté
                {
                    if (compare(Data.g[i], olda) == true)
                    {
                        Data.g[i] = newa;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            else
            {
                if (trover(newa) == false)
                {
#pragma warning disable CS0162 // Impossible d'atteindre le code détecté
                    for (int i = 0; i < Data.g.Count;i++)
#pragma warning restore CS0162 // Impossible d'atteindre le code détecté
                    {
                        if (compare(Data.g[i], olda) == true)
                        {
                            Data.g[i] = newa;
                            return true;
                        }
                        else
                        {
                            return false; 
                        }
                    }
                }
            }
            return false;
        }
        public bool supprimer(produit c)
        {

#pragma warning disable CS0162 // Impossible d'atteindre le code détecté
            for (int i = 0; i < Data.g.Count;i++)
#pragma warning restore CS0162 // Impossible d'atteindre le code détecté
            {
                if (compare(Data.g[i], c) == true)
                {
                    Data.g.RemoveAt(i);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        //public static List<produit> c = new List<produit>();
        //public static List<produit> t = new List<produit>();


        //public bool ajouter(produit A)
        //{
        //    if (trouver(A.numerop) == false)
        //    {    
        //        c.Add(A);
        //        return true;
        //    }     
        //    else  
        //    {
        //        return false;
        //    }

        //}
        //public bool trouver(int num)
        //{
        //    foreach (produit a in c)
        //    {
        //        if (a.numerop == num)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public int pos(int num)
        //{
        //    int i;
        //    for (i = 0; i < c.Count; i++)
        //    {
        //        if (c[i].numerop == num)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        //public bool modifier(produit encien, produit nouveau)
        //{
        //    if (trouver(encien.numerop) == true)
        //    {
        //        c[pos(encien.numerop)] = nouveau;
        //        return true;

        //    }
        //    else
        //    {                     
        //        return false;
        //    }


        //}
        //public bool supprimer(produit x)                                                   
        //{  
        //    if (trouver(x.numerop) == true)   
        //    {
        //        c.RemoveAt(pos(x.numerop));                                                                                  
        //        return true;                                                                                                                                         
        //    }                                                                                             
        //    else                                                                                                                                   
        //    {                                               
        //        return false;     
        //    }
        //}  
        //public List<produit> recherarticle(int num, string nom)       
        //{
        //   c.Clear();
        //    foreach (produit d in c) 
        //    {                                                                                
        //        if (d.numerop == num && d.Nomp.Substring(0, nom.Length) == nom)                                             
        //        {
        //           c.Add(d);                                                                                                                
        //        }

        //    }
        //    return c;                   
        //}
        public static List<produit> rechercher(string nom)
        {
            List<produit> x = new List<produit>();
            foreach (produit a in Data.g)
            {
                if (a.nomp.Length >= nom.Length)
                {
                    if (a.nomp.Substring(0, nom.Length).ToLower() == nom.ToLower())
                    {
                        x.Add(a);
                    }
                }
            }
            return x;
        }
    }
}
