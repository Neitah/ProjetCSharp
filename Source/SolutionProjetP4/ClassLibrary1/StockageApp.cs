using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class StockageApp
    {
        /// <summary>
        /// ??? 
        /// </summary>
        public IList<Profil> lesProfils;

        /// <summary>
        /// Liste des utilisateurs
        /// </summary>
        public IList<Utilisateur> lesUtilisateurs;

        /// <summary>
        /// Constructeur 
        /// </summary>
      
        public StockageApp()
        {
            lesProfils = new List<Profil>();
            lesUtilisateurs = new List<Utilisateur>();
        }

        /// <summary>
        /// Méthode "AjoutProfil"  
        /// </summary>
        /// <param name="p"> Profil à ajouter </param>
        /// 
        /// Ajoute un profil dans la liste "LesProfils"
        public void AjoutProfil(Profil p)
        {
            lesProfils.Add(p);
        }

        /// <summary>
        /// Méthode "AjoutUtilisateur"  
        /// </summary>
        /// <param name="u"> Utilisateur à ajouter </param>
        /// 
        /// Ajoute un utilisateur dans la liste "lesUtilisateurs"
        public void AjoutUtilisateur(Utilisateur u)
        {
            lesUtilisateurs.Add(u);
        }
    }
}
