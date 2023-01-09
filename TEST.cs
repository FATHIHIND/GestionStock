using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_stock
{
  public class TEST:IComparable<TEST>
    {
        private String prix_achat;
        private String quantité_achat;
        private string fourniseur;
        private String designation;
        private DateTime date;
       
        public String Prix_achat
        { get => prix_achat;
          set => prix_achat = value;
        }
        public String Quantité_achat
        { get => quantité_achat;
          set => quantité_achat = value;
        }
        public string Fourniseur
        {
            get => fourniseur;
            set => fourniseur = value;
        }
        public string Designation
        { get => designation;
          set => designation = value;
        }
        public DateTime Date
        { get => date;
          set => date = value;
        }
       

        public TEST() { }
        public TEST(String NUM)
        {
            Prix_achat = NUM;
        }

        //public static List<TEST> f = new List<TEST>();
        //public static List<TEST> t = new List<TEST>();
        //public bool ajouter(TEST A)
        //{
        //    if (trouver(A.Num) == false)
        //    {
        //        f.Add(A);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
        //public bool trouver(int num)
        //{
        //    foreach (TEST a in f)
        //    {
        //        if (a.Num == num)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        public static List<TEST> c = new List<TEST>();
        public bool ajouter(TEST A)
        {
            if (trouver(A.Prix_achat) == false)
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
            foreach (TEST a in c)
            {
                if (a.prix_achat == num)
                {
                    return true;
                }
            }
            return false;
        }
        public int CompareTo(TEST other)
        {
            /* if (prix_achat > other.prix_achat)imposible de comparer le type string en string
                 return 1;
             else if (prix_achat < other.prix_achat)
                 return -1;
             else return 0;
             */
            return 1;
        }
    }
}
