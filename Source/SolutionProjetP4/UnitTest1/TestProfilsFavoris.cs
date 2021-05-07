using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesApp;
using System;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAjoutProfilFavoriDoublon()
        {

            // Création d'un profil
            Profil profil = new Profil("Nom Profil 1", "dé de Vie", "équipement", "armes et armures", "divers", "description", "chemin");
            // Création d'un utilisateur
            Utilisateur utilisateur = new Utilisateur("Utilisateur 1", "Mot de passe utilisateur 1");
            utilisateur.AjoutProfilFavori(profil);
            utilisateur.AjoutProfilFavori(profil);
            if (utilisateur.ProfilsFavoris.Count == 1)
            {
                return;
            }
            else
            {
                throw new Exception("PB");
            }
        }
    }
}
