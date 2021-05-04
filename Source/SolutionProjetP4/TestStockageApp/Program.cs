using System;
using ClassLibrary1;

namespace TestStockageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test du stockage de l'application :");

            Console.WriteLine("-----------------------------------------------\n");

            Console.WriteLine("Création d'un utilisateur\n");
            Utilisateur u1 = new Utilisateur("Nom utilisateur 1", "Mot de passe utilisateur 1");
            Console.WriteLine(u1);

            Console.WriteLine("-----------------------------------------------\n");

            Console.WriteLine("Création d'un profil\n");


            Console.WriteLine("Création de compétences \n");
            Compétence c1 = new Compétence("Description compétences 1", "Nom compétences 1");
            Compétence c2 = new Compétence("Description compétences 2", "Nom compétences 2");

            Console.WriteLine("Création de voies \n");
            Voie v1 = new Voie("Voie 1");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);

            Profil p1 = new Profil("Nom Profil 1", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            p1.AjoutVoie(v1);
            Console.WriteLine(p1);

            Console.WriteLine("-----------------------------------------------\n");

            Console.WriteLine("Création d'une boite de jeu \n");
            BoiteDeJeu b1 = new BoiteDeJeu("Description de la boite 1", "Magasin boite 1", "Nom de la boite  1", "chemin");
            Console.WriteLine(b1);


            Console.WriteLine("==============================================\n");
            Console.WriteLine("Création stockage app: \n");
            StockageApp sa1 = new StockageApp();

            Console.WriteLine("Remplissage des listes\n");
            sa1.AjoutProfil(p1);
            sa1.AjoutUtilisateur(u1);
            sa1.AjoutBoite(b1);


            Console.WriteLine("Affichage stockage : \n");
            Console.WriteLine(sa1);
        }
    }
}
