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
        public override StockageApp Charger (string chemin)
        {
            StockageApp stock = new StockageApp();
            stock = new StockageApp();

            BoiteDeJeu b1 = new BoiteDeJeu("Description de la boite 1", "Magasin boite 1", "Nom de la boite  1", "chemin");
            stock.AjoutBoite(b1);

            Compétence c1 = new Compétence("Description compétences 1", "Nom compétences 1");
            Compétence c2 = new Compétence("Description compétences 1", "Nom compétences 1");
            Compétence c3 = new Compétence("Description compétences 3", "Nom compétences 3");
            Compétence c4 = new Compétence("Description compétences 4", "Nom compétences 4");
            Compétence c5 = new Compétence("Description compétences 5", "Nom compétences 5");
            Compétence c6 = new Compétence("Description compétences 6", "Nom compétences 6");
            Compétence c7 = new Compétence("Description compétences 2", "Nom compétences 2");

            Voie v1 = new Voie("Voie 1");
            Voie v2 = new Voie("Voie 1");
            v1.AjoutCompétence(c1);
            v1.AjoutCompétence(c2);
            v1.AjoutCompétence(c7);
            v1.AjoutCompétence(c3);
            v1.AjoutCompétence(c4);
            v1.AjoutCompétence(c5);
            v2.AjoutCompétence(c1);
            v2.AjoutCompétence(c2);
            v2.AjoutCompétence(c7);
            v2.AjoutCompétence(c3);
            v2.AjoutCompétence(c4);
            v2.AjoutCompétence(c5);

            Profil p1 = new Profil("Nom Profil 1", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            Profil p2 = new Profil("Nom Profil 1", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            p1.AjoutVoie(v1);
            p2.AjoutVoie(v2);
            stock.AjoutProfil(p1);
            stock.AjoutProfil(p2);

            Utilisateur u1 = new Utilisateur("Nom utilisateur 1", "Mot de passe utilisateur 1");
            u1.AjoutProfilFavori(p1);
            u1.AjoutProfilHybride(p2);
            stock.AjoutUtilisateur(u1);

            return stock;
        }
    }
}
