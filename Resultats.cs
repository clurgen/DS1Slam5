using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{
    class Resultats
    {
        private int tempsRealise;
        private Epreuve uneEpreuve;
        private Participant unParticipant;

        public Resultats(Participant unParticipant, Epreuve uneEpreuve, int tempsRealise) 
        {
            this.unParticipant = unParticipant;
            this.uneEpreuve = uneEpreuve;
            this.tempsRealise = tempsRealise;
        }

        public int GetTempsRealise() 
        {
            return this.tempsRealise;
        }

        public Epreuve GetEpreuve() 
        {
            return this.uneEpreuve;
        }
    }
}
