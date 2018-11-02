using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{
    class Participant
    {
        private DateTime dateInscription;
        private int id;
        static private int lastId;
        private string nom;
        private List<Resultats> lesResultats;



        public Participant(string nom, DateTime dateInscription)
        {
            this.nom = nom;
            this.dateInscription = dateInscription;
            this.id = lastId;
            this.lesResultats = new List<Resultats>();
            lastId = lastId + 1;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public int GetTempsTotal()
        {
            int totale = 0;
            foreach (Resultats unResultat in lesResultats)
            {
                totale = unResultat.GetTempsRealise() + totale;
            }
            return totale;
         }

        public DateTime GetDateInscription()
        {
            return this.dateInscription;
        }

        public bool resultatPresent(Epreuve uneEpreuve)
        {
            foreach (Resultats unResultat in lesResultats)
            {
                if (unResultat.GetEpreuve().GetNom() == uneEpreuve.GetNom())
                {
                    return true ;
                }
            }
            return false;
        }

        public bool HorsDelai()
        {
            foreach (Resultats unResultat in lesResultats)
            {
                if(unResultat.GetTempsRealise() > unResultat.GetEpreuve().GetTempEliminatoire() )
                {
                    return true;
                }
            }
            return false;
        }

        public List<Resultats> LesResultats
        {
            get { return lesResultats; }
        }

        public void Add(Epreuve uneEpreuve, int tempsRealise) 
        {
            if (resultatPresent(uneEpreuve) == false)
            {
                Resultats unResultat = new Resultats(this, uneEpreuve, tempsRealise);
                this.lesResultats.Add(unResultat);
            }
        }
    }
}
