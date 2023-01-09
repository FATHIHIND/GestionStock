using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_stock
{
  public   class client/*:liste */
    {
        private int numc;
        private string nomc;
        private String telc;
        private String adresse;
        private String email;
        //private VenteS fd;

        public int Numc { get => numc; set => numc = value; }
        public string Nomc { get => nomc; set => nomc = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public String Telc { get => telc; set => telc = value; }
        public String Email { get => email; set => email = value; }
        public client() { }
        public client(int nu,string no, String em,String tel, String  adre)
        {
            numc = nu;
            nomc = no;
            Telc = tel;
            Adresse = adre;
            Email = em;
        }

        public static List<client> c = new List<client>();
        public static List<client> t = new List<client>();


        public bool ajouter(client  A)
        {
            if (trouver(A.numc) == false)
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
            foreach (client a in c)
            {
                if (a.numc == num)
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
                if (c[i].numc== num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool modifier(client encien,client nouveau)
        {
            if (trouver(encien.numc) == true)
            {
                c[pos(encien.numc)] = nouveau;
                return true;

            }
            else
            {
                return false;
            }


        }
        public bool supprimer(client x)
        {
            if (trouver(x.numc) == true)
            {
                c.RemoveAt(pos(x.numc));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
