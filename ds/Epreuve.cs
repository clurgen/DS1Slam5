using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{
    class Epreuve
    {
        private int distance;
        private string nom;
        private int tempsEliminatoire;

        public Epreuve(string nom, int distance) 
        {
            this.distance = distance;
            this.nom = nom;
        }

        public int GetDistance() 
        {
            return this.distance;
        }

        public string GetNom()
        {
            return this.nom;
        }

        public int GetTempEliminatoire()
        {
            return this.tempsEliminatoire;
        }

        public int SetTempsEliminatoire 
        {
            set { this.tempsEliminatoire = value; }
        }
    }
}
