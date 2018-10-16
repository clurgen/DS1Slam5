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
            Participant clement = new Participant("clement",date);
            Tri clemtri = new Tri("M",1500,4000,1000);
            Epreuve natation = new Epreuve("natation", 1500);
            Epreuve velo = new Epreuve("velo", 4000);
            Epreuve course = new Epreuve("course", 1500);
            Resultats resultatNatation = new Resultats(clement,natation,45);
            Resultats resultatVelo = new Resultats(clement, velo, 45);
            Resultats resultatCourse = new Resultats(clement, course, 45);

            Console.WriteLine(clement.GetTempsTotal());
            Console.WriteLine(clement.HorsDelai());
            Console.WriteLine(clement.resultatPresent(velo));
            Console.WriteLine(clement.resultatPresent(course));
            Console.WriteLine(clement.resultatPresent(natation));

            Console.ReadLine();
        }
    }
}
