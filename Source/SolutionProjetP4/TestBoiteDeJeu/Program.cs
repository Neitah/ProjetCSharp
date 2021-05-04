using System;
using ClassLibrary1;

namespace TestBoiteDeJeu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test création d'une boite de jeu :\n");
            Console.WriteLine("------------------------------------------------\n");

            BoiteDeJeu b1 = new BoiteDeJeu("Description de la boite 1","Magasin boite 1","Nom de la boite  1","chemin");
            Console.WriteLine(b1);
            Console.WriteLine(b1.Nom);
        }
    }
}
