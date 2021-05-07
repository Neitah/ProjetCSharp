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

            // Cr�ation d'un profil
            Profil profil = new Profil("Nom Profil 1", "d� de Vie", "�quipement", "armes et armures", "divers", "description", "chemin");
            // Cr�ation d'un utilisateur
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
