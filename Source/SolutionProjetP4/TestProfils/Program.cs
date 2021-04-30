using System;
using ClassLibrary1;

namespace TestProfils
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la création d'un profil\n");

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("\nCréation de 5 compétences : \n");

            Compétence c1 = new Compétence("Description compétences 1", "Nom compétences 1");
            Console.WriteLine(c1);
            Compétence c2 = new Compétence("Description compétences 1", "Nom compétences 1");
            Console.WriteLine(c2);
            Compétence c3 = new Compétence("Description compétences 3", "Nom compétences 3");
            Console.WriteLine(c3);
            Compétence c4 = new Compétence("Description compétences 4", "Nom compétences 4");
            Console.WriteLine(c4);
            Compétence c5 = new Compétence("Description compétences 5", "Nom compétences 5");
            Console.WriteLine(c5);
            Compétence c6 = new Compétence("Description compétences 6", "Nom compétences 6");
            Console.WriteLine(c6);
            Compétence c7 = new Compétence("Description compétences 2", "Nom compétences 2");
            Console.WriteLine(c7);
            Console.WriteLine("\n-----------------------------------------------");

            Console.WriteLine("\nCréation d'une voie : \n");

            Voie v1 = new Voie("Voie 1");
            Voie v2 = new Voie("Voie 1");
            Console.WriteLine(v1);
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            v1.AjoutCompétence(c7);
            v1.AjoutCompétence(c3);
            v1.AjoutCompétence(c4);
            v1.AjoutCompétence(c5);
            v1.AjoutCompétence(c6);
            
            v2.AjoutCompétence(c1);
            v2.AjoutCompétence(c2);
            v2.AjoutCompétence(c7);
            v2.AjoutCompétence(c3);
            v2.AjoutCompétence(c4);
            v2.AjoutCompétence(c5);
            v2.AjoutCompétence(c6);
            Console.WriteLine(v1);

            Console.WriteLine("\n-----------------------------------------------");

            Console.WriteLine("\nCréation d'un profil : \n");
            Profil p1 = new Profil("Nom Profil 1", "dé de Vie", "équipement", "armes et armures", "divers", "description") ;
            Profil p2 = new Profil("Nom Profil 1", "dé de Vie", "équipement", "armes et armures", "divers", "description") ;
            Console.WriteLine(p1);
            p1.AjoutVoie(v1);
            p2.AjoutVoie(v2);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
