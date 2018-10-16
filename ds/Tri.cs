using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{
    class Tri
    {
        private string nature;
        private Epreuve natation;
        private Epreuve course;
        private Epreuve velo;
        private List<Participant> lesParticipants;

        public Tri(string nature, int distanceNatation, int distanceVelo, int distanceCourse)
        {
            this.nature = nature;
            this.natation = new Epreuve("Natation",distanceNatation);
            this.course = new Epreuve("Course", distanceCourse);
            this.velo = new Epreuve("Velo", distanceVelo);
        }

        public string GetNature()
        {
            return this.nature;
        }

        public Epreuve GetEpreuve(string nomEpreuve)
        {
            switch (nomEpreuve)
            {
                case "natation":
                    return this.natation;
                case "velo":
                    return this.velo;
                default:
                    return this.course;
            }
        }

        public List<Participant> GetLesTemps()
        {
            List<Participant> enCours = new List<Participant>();
            foreach(Participant unParticipant in lesParticipants)
            {
                if (unParticipant.HorsDelai() == false)
                {
                    enCours.Add(unParticipant);
                }
            }
            return enCours;
        }

        public int GetDistanceTotale()
        {
            int totale = this.natation.GetDistance() + this.velo.GetDistance() + this.course.GetDistance();
            return totale;
        }

        public Participant GetParticipantById(int id)
        {
            foreach (Participant unParticipant in lesParticipants)
            {
                if (id == unParticipant.GetId())
                {
                    return unParticipant;
                }
            }
            return null;
        }

        public void AddParticipant(Participant unParticipant)
        {
            this.lesParticipants.Add(unParticipant);
        }
    }
}
