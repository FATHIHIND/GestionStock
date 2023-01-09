using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestion_stock
{
  public  class DemendeAchat
    {
        private string num;
        private DateTime dateDa;
        private DateTime datea;
        private bool validité;
        private bool accepté;
        private bool transformer;
        
        /*liste demende achts*/
        public static List<DemendeAchat> D = new List<DemendeAchat>();

        public string Num { get => num; set => num = value; }
        public DateTime DateDa { get => dateDa; set => dateDa = value; }
        public DateTime Datea { get => datea; set => datea = value; }
        public bool Validité { get => validité; set => validité = value; }
        public bool Accepté { get => accepté; set => accepté = value; }
        public bool Transformer { get => transformer; set => transformer = value; }
       

        public bool ajouter()
        {
            if (trover() == false)
            {
                Data.r.Add(this);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool compare(DemendeAchat e, DemendeAchat b)
        {
            if (e.Num == b.Num)
            {
                return true;
            }
            else
            {
                if (e.validité == b.Validité)
                {
                    return true;
                }
            }
            return false;
        }
        public bool trover()
        {
#pragma warning disable CS0162 // Impossible d'atteindre le code détecté
            for (int i = 0; i < Data.r.Count; i++)
#pragma warning restore CS0162 // Impossible d'atteindre le code détecté
            {
                if (compare(Data.r[i], this) == true)
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
        public bool trover(DemendeAchat v)
        {
#pragma warning disable CS0162 // Impossible d'atteindre le code détecté
            for (int i = 0; i < Data.r.Count;i++)
#pragma warning restore CS0162 // Impossible d'atteindre le code détecté
            {
                if (compare(Data.r[i], v) == true)
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
        public bool modifier(DemendeAchat olda, DemendeAchat newa)
        {
            if (compare(olda, newa) == true)
            {
#pragma warning disable CS0162 // Impossible d'atteindre le code détecté
                for (int i = 0; i < Data.r.Count;i++)
#pragma warning restore CS0162 // Impossible d'atteindre le code détecté
                {
                    if (compare(Data.r[i], olda) == true)
                    {
                        Data.r[i] = newa;
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
                    for (int i = 0; i < Data.r.Count;i++)
#pragma warning restore CS0162 // Impossible d'atteindre le code détecté
                    {
                        if (compare(Data.r[i], olda) == true)
                        {
                            Data.r[i] = newa;
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
        public bool supprimer(DemendeAchat c)
        {

#pragma warning disable CS0162 // Impossible d'atteindre le code détecté
            for (int i = 0; i < Data.r.Count;i++)
#pragma warning restore CS0162 // Impossible d'atteindre le code détecté
            {
                if (compare(Data.r[i], c) == true)
                {
                    Data.r.RemoveAt(i);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static List<DemendeAchat> rechercher(string nom)
        {
            List<DemendeAchat> x = new List<DemendeAchat>();
            foreach (DemendeAchat a in Data.r)
            {
                if (a.num.Length >= nom.Length)
                {
                    if (a.num.Substring(0, nom.Length).ToLower() == nom.ToLower())
                    {
                        x.Add(a);
                    }
                }
            }
            return x;
        }

    }
}
