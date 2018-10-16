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
        private string nom;
        private List<Resultats> lesResultats;

        public Participant(string nom, DateTime dateInscription)
        {
            this.nom = nom;
            this.dateInscription = dateInscription;
            this.id = id;
            this.lesResultats = new List<Resultats>();
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
                if(unResultat.GetTempsRealise() < unResultat.GetEpreuve().GetTempEliminatoire() )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
