using ClassesApp;
using System;

namespace Data
{
    public class Stub : Chargeur
    {
        /// <summary>
        /// Méthode chargeant des données préconçues
        /// </summary>
        /// <param name="chemin">paramètre inutilisé mais nécessaire</param>
        /// <returns name="stock">Ensemble de données préconçues</returns>
        public override StockageApp Charger(string chemin)
        {

            /// Stockage application :

            StockageApp stock = new StockageApp();

            /// Boite de jeu :

            BoiteDeJeu b1 = new BoiteDeJeu("Description de la boite 1", "Magasin boite 1", "Nom de la boite  1", "chemin");
            stock.AjoutBoite(b1);

            /// Compétences :

            Compétence c1 = new Compétence("Description compétences 1", "Nom compétences 1");
            Compétence c2 = new Compétence("Description compétences 2", "Nom compétences 2");
            Compétence c3 = new Compétence("Description compétences 3", "Nom compétences 3");
            Compétence c4 = new Compétence("Description compétences 4", "Nom compétences 4");
            Compétence c5 = new Compétence("Description compétences 5", "Nom compétences 5");

            Compétence c6 = new Compétence("Description compétences 6", "Nom compétences 6");
            Compétence c7 = new Compétence("Description compétences 7", "Nom compétences 7");
            Compétence c8 = new Compétence("Description compétences 8", "Nom compétences 8");
            Compétence c9 = new Compétence("Description compétences 9", "Nom compétences 9");
            Compétence c10 = new Compétence("Description compétences 10", "Nom compétences 10");

            Compétence c11 = new Compétence("Description compétences 11", "Nom compétences 11");
            Compétence c12 = new Compétence("Description compétences 12", "Nom compétences 12");
            Compétence c13 = new Compétence("Description compétences 13", "Nom compétences 13");
            Compétence c14 = new Compétence("Description compétences 14", "Nom compétences 14");
            Compétence c15 = new Compétence("Description compétences 15", "Nom compétences 15");

            /// Voies

            Voie v1 = new Voie("Voie 1");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            v1.AjoutCompétence(c3);
            v1.AjoutCompétence(c4);
            v1.AjoutCompétence(c5);

            Voie v2 = new Voie("Voie 2");
            v2.AjoutCompétence(c6);
            v2.AjoutCompétence(c7);
            v2.AjoutCompétence(c8);
            v2.AjoutCompétence(c9);
            v2.AjoutCompétence(c10);

            Voie v3 = new Voie("Voie 2");
            v3.AjoutCompétence(c11);
            v3.AjoutCompétence(c12);
            v3.AjoutCompétence(c13);
            v3.AjoutCompétence(c14);
            v3.AjoutCompétence(c15);

            Voie v4 = new Voie("Voie 2");
            v4.AjoutCompétence(c10);
            v4.AjoutCompétence(c2);
            v4.AjoutCompétence(c13);
            v4.AjoutCompétence(c6);
            v4.AjoutCompétence(c9);

            Voie v5 = new Voie("Voie 2");
            v5.AjoutCompétence(c6);
            v5.AjoutCompétence(c2);
            v5.AjoutCompétence(c3);
            v5.AjoutCompétence(c14);
            v5.AjoutCompétence(c1);


            /// Profils :

            Profil p1 = new Profil("Nom Profil 1", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            p1.AjoutVoie(v1);
            p1.AjoutVoie(v2);
            p1.AjoutVoie(v3);
            p1.AjoutVoie(v4);
            stock.AjoutProfil(p1);

            Profil p2 = new Profil("Nom Profil 2", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            p2.AjoutVoie(v2);
            p2.AjoutVoie(v1);
            p2.AjoutVoie(v5);
            stock.AjoutProfil(p2);

            Profil p3 = new Profil("Nom Profil 3", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            p3.AjoutVoie(v1);
            p3.AjoutVoie(v3);
            p3.AjoutVoie(v5);
            stock.AjoutProfil(p2);

            Profil p4 = new Profil("Nom Profil 4", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            p4.AjoutVoie(v2);
            p4.AjoutVoie(v3);
            p4.AjoutVoie(v4);
            stock.AjoutProfil(p2);

            /// Utilisateurs

            Utilisateur u1 = new Utilisateur("Nom utilisateur 1", "Mot de passe utilisateur 1");
            u1.AjoutProfilFavori(p1);
            u1.AjoutProfilHybride(p2);
            stock.AjoutUtilisateur(u1);

            Utilisateur u2 = new Utilisateur("Nom utilisateur 2", "Mot de passe utilisateur 2");
            u2.AjoutProfilFavori(p3);
            u2.AjoutProfilHybride(p4);
            stock.AjoutUtilisateur(u1);

            Utilisateur u3 = new Utilisateur("Nom utilisateur 3", "Mot de passe utilisateur 3");
            u3.AjoutProfilFavori(p1);
            u3.AjoutProfilHybride(p4);
            stock.AjoutUtilisateur(u1);


            return stock;
        }
    }
}
