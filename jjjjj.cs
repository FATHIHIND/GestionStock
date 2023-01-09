using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace la_gestion_d_une_équipe_de_football
{
    /*-------question 1.a------------ */
   public class la_classe_joueur:la_class_equipe
    {
        public string Nom;
        private DateTime date_Naissance;
        public string position_sur_terrain;
        public bool reserve;
    /*------------question 1.b----------*/
        public string Nom1
        { get => Nom;
          set => Nom = value;
        }
      
        public string Position_sur_terrain
        { get => position_sur_terrain;
          set => position_sur_terrain = value;
        }
        public bool Reserve
        { get => reserve;
          set => reserve = value;
        }
        public DateTime Date_Naissance
        { get => date_Naissance;
          set => date_Naissance = value;
        }

        /*---------question 1.c--------------*/
        public la_classe_joueur() { }
    public la_classe_joueur(string nomjoueur, DateTime datenaissance, string position_surterrain, bool reserve)
    {
            Nom = nomjoueur;
            Date_Naissance = datenaissance;
            position_sur_terrain = position_surterrain;
            this.reserve = reserve;

    }
    /*------------question 1.d--------------*/
    public virtual  float  calculer_prime(int jouer, int gagner)
        {
            float prime_joueur= 10000 * (gagner / jouer);
            //if(reserve==false)
            //{
            //    prime_joueur = 10000 * (gagner / jouer);
            //}
            //else
            //if(reserve==true) 
            //{
            //    prime_joueur = (10000 * (gagner / jouer))/2;
            //}
            if (reserve == true)
            {

                prime_joueur = prime_joueur / 2;
            }
            else
                throw new Exception("ygyh");
            return prime_joueur; 
            /* throw new exeption("gjkh!");*/
        }
        /*----------------qestion 5.a-----------*/
        public new static List<la_classe_joueur> j = new List<la_classe_joueur>();
        public bool ajouter(la_classe_joueur A)
        {
            if (trouver(A.Nom) == false)
            {
                j.Add(A);
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool trouver(string nom)
        {
            foreach (la_classe_joueur a in j)
            {
                if (a.Nom == nom)
                {
                    return true;
                }
            }
            return false;
        }




































































































































    }
}
