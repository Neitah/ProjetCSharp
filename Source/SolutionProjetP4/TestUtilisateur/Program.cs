using System;
using ClassLibrary1;

namespace TestUtilisateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la création d'un utilisateur\n");

            Console.WriteLine("-----------------------------------------------\n");

            Utilisateur u1 = new Utilisateur("Nom utilisateur 1", "Mot de passe utilisateur 1");
            Console.WriteLine(u1);

        }
    }
}
