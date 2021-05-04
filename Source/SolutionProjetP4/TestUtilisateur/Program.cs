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

            Console.WriteLine("Création de compétences \n");

            Compétence c1 = new Compétence("Description compétences 1", "Nom compétences 1");
            Console.WriteLine(c1);
            Compétence c2 = new Compétence("Description compétences 2", "Nom compétences 2");
            Console.WriteLine(c2);

            Console.WriteLine("Création de voies \n");
            Voie v1 = new Voie("Voie 1");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            Console.WriteLine(v1);

            Console.WriteLine("Création de profils \n");
            Profil p1 = new Profil("Nom Profil 1", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            p1.AjoutVoie(v1);
            Console.WriteLine(p1);

            Console.WriteLine("-----------------------------------------------\n");

            Console.WriteLine("Ajout d'un profil hybride dans un utilisateur\n");
            u1.AjoutProfilHybride(p1);
            Console.WriteLine(u1);


            Console.WriteLine("Ajout d'un profil favori dans un utilisateur\n");
            u1.AjoutProfilFavori(p1);
            Console.WriteLine(u1);

        }
    }
}
