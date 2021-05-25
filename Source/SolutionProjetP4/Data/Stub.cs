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

            BoiteDeJeu b1 = new BoiteDeJeu("Description de la boite 1", "Magasin boite 1", "Nom de la boite  1", "\\Images;Component\\boiteDeJeuInitationAventure.png");
            BoiteDeJeu b2 = new BoiteDeJeu("Description de la boite 2", "Magasin boite 2", "Nom de la boite  2", "\\Images;Component\\boiteDeJeuInitationAventureVengeance.png");
            BoiteDeJeu b3 = new BoiteDeJeu("Description de la boite 3", "Magasin boite 3", "Nom de la boite  3", "\\Images;Component\\boiteDeJeuCthulhu.png");
            stock.AjoutBoite(b1);
            stock.AjoutBoite(b2);
            stock.AjoutBoite(b3);


            /// Compétences :

            Compétence c1 = new Compétence("Description compétences 1", "Mécanisme");
            Compétence c2 = new Compétence("Description compétences 2", "Tir de semonce");
            Compétence c3 = new Compétence("Description compétences 3", "Tir de barrage");
            Compétence c4 = new Compétence("Description compétences 4", "Couleuvrine");
            Compétence c5 = new Compétence("Description compétences 5", "Feu nourri");

            Compétence c6 = new Compétence("Description compétences 6", "Chimiste");
            Compétence c7 = new Compétence("Description compétences 7", "Démolition");
            Compétence c8 = new Compétence("Description compétences 8", "Poudre puissante");
            Compétence c9 = new Compétence("Description compétences 9", "Piège explosif");
            Compétence c10 = new Compétence("Description compétences 10", "Boulet explosif");

            Compétence c11 = new Compétence("Description compétences 11", "Action concertée");
            Compétence c12 = new Compétence("Description compétences 12", "À couvert");
            Compétence c13 = new Compétence("Description compétences 13", "Combattant aguerri");
            Compétence c14 = new Compétence("Description compétences 14", "Combat de masse");
            Compétence c15 = new Compétence("Description compétences 15", "Constitution héroïque");

            Compétence c16 = new Compétence("Description compétences 16", "Plus vite que son ombre");
            Compétence c17 = new Compétence("Description compétences 17", "Cadence de tir");
            Compétence c18 = new Compétence("Description compétences 18", "Tir double");
            Compétence c19 = new Compétence("Description compétences 19", "As de la gâchette");
            Compétence c20 = new Compétence("Description compétences 20", "Dextérité héroïque");

            Compétence c21 = new Compétence("Description compétences 21", "Joli coup");
            Compétence c22 = new Compétence("Description compétences 22", "Tir précis");
            Compétence c23 = new Compétence("Description compétences 23", "Défaut dans la cuirasse");
            Compétence c24 = new Compétence("Description compétences 24", "Tir parabolique");
            Compétence c25 = new Compétence("Description compétences 25", "Tir mortel");

            /// Voies

            Voie v1 = new Voie("Voie de l'artilleur");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            v1.AjoutCompétence(c3);
            v1.AjoutCompétence(c4);
            v1.AjoutCompétence(c5);

            Voie v2 = new Voie("Voie des explosifs");
            v2.AjoutCompétence(c6);
            v2.AjoutCompétence(c7);
            v2.AjoutCompétence(c8);
            v2.AjoutCompétence(c9);
            v2.AjoutCompétence(c10);

            Voie v3 = new Voie("Voie du champ de bataille");
            v3.AjoutCompétence(c11);
            v3.AjoutCompétence(c12);
            v3.AjoutCompétence(c13);
            v3.AjoutCompétence(c14);
            v3.AjoutCompétence(c15);

            Voie v4 = new Voie("Voie du pistolero");
            v4.AjoutCompétence(c16);
            v4.AjoutCompétence(c17);
            v4.AjoutCompétence(c18);
            v4.AjoutCompétence(c19);
            v4.AjoutCompétence(c20);

            Voie v5 = new Voie("Voie de la précision");
            v5.AjoutCompétence(c21);
            v5.AjoutCompétence(c22);
            v5.AjoutCompétence(c23);
            v5.AjoutCompétence(c24);
            v5.AjoutCompétence(c25);


            /// Profils :

            Profil p1 = new Profil("Arquebusier", "1d8", "Pétoire, épée longue, dague, armure de cuir", "armes de contact à une main, armes à distance, armes à poudre, armure jusqu'à la chemise de maille", "divers", "L’arquebusier est un dur à cuir, un soldat ou un mercenaire habitué des champs de bataille. C’est un spécialiste du combat à distance et plus particulièrement des armes à feu et des explosifs.", "\\Images;Component\\Profil\\Arquebusier.PNG");
            p1.AjoutVoie(v1);
            p1.AjoutVoie(v2);
            p1.AjoutVoie(v3);
            p1.AjoutVoie(v4);
            p1.AjoutVoie(v5);
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
            stock.AjoutProfil(p3);

            Profil p4 = new Profil("Nom Profil 4", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            p4.AjoutVoie(v2);
            p4.AjoutVoie(v3);
            p4.AjoutVoie(v4);
            stock.AjoutProfil(p4);

            /// Utilisateurs

            Utilisateur u1 = new Utilisateur("utilisateur1", "Motdepasse1");
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
