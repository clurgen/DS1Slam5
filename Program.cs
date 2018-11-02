using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ds
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2018,09,14);
            Participant clement = new Participant("Clement",date);
            Tri clemtri = new Tri("M",1500,4000,1000);
            Epreuve natation = new Epreuve("natation", 1500);
            Epreuve velo = new Epreuve("velo", 4000);
            Epreuve course = new Epreuve("course", 1500);
            Resultats resultatNatation = new Resultats(clement,natation,45);
            Resultats resultatVelo = new Resultats(clement, velo, 45);
            Resultats resultatCourse = new Resultats(clement, course, 45);

            clement.Add(course,100);
            clement.Add(natation, 45);

            bool resultatV = clement.resultatPresent(velo);
            if (resultatV == false)
                Console.WriteLine("{0} n'as pas de resultat à l'epreuve de Velo.\n", clement.GetNom());
            else
            {
                   foreach (Resultats unResultat in clement.LesResultats)
            {
                if (unResultat.GetEpreuve().GetNom() == velo.GetNom())
                {
                    Console.WriteLine("Resultat de {0} à l'epreuve de velo: {1}min.\n", clement.GetNom(), unResultat.GetTempsRealise());
                }
            }

            }

            bool resultatC = clement.resultatPresent(course);
            if (resultatC == false)
                Console.WriteLine("{0} n'as pas de resultat à l'epreuve de Course.\n", clement.GetNom());
            else
            {
                foreach (Resultats unResultat in clement.LesResultats)
                {
                    if (unResultat.GetEpreuve().GetNom() == course.GetNom())
                    {
                        Console.WriteLine("Resultat de {0} à l'epreuve de Course: {1}min.\n", clement.GetNom(), unResultat.GetTempsRealise());
                    }
                }

            }

            bool resultatN = clement.resultatPresent(natation);
            if (resultatN == false)
                Console.WriteLine("{0} n'as pas de resultat à l'epreuve de Natation.\n", clement.GetNom());
            else
            {
                foreach (Resultats unResultat in clement.LesResultats)
                {
                    if (unResultat.GetEpreuve().GetNom() == natation.GetNom())
                    {
                        Console.WriteLine("Resultat de {0} à l'epreuve de Natation: {1}min.\n", clement.GetNom(), unResultat.GetTempsRealise());
                    }
                }

            }

            Console.WriteLine("Le temps total du Participant est de: {0}min.\n", clement.GetTempsTotal());

            bool hors = clement.HorsDelai();
            if (hors == true)
                Console.WriteLine("Le participant est hors delai.\n");
            else
                Console.WriteLine("Le participant n'est pas hors delai.\n");

            Console.ReadLine();
        }
    }
}
