using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class StockageApp 
    {
        /// <summary>
        /// Liste de tous profils 
        /// </summary>
        public IList<Profil> lesProfils;

        /// <summary>
        /// Liste des utilisateurs
        /// </summary>
        public IList<Utilisateur> lesUtilisateurs;

        /// <summary>
        /// Liste des boites de jeu
        /// </summary>
        public IList<BoiteDeJeu> lesBoites;

        /// <summary>
        /// Constructeur 
        /// </summary>

        public StockageApp()
        {
            lesProfils = new List<Profil>();
            lesUtilisateurs = new List<Utilisateur>();
            lesBoites = new List<BoiteDeJeu>();
        }

        /// <summary>
        /// Méthode "AjoutProfil"  
        /// </summary>
        /// <param name="p"> Profil à ajouter </param>
        /// 
        /// Ajoute un profil dans la liste "LesProfils"
        public void AjoutProfil(Profil p)
        {
            if(!lesProfils.Contains(p))
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
            if (!lesUtilisateurs.Contains(u))
                lesUtilisateurs.Add(u);
        }

        /// <summary>
        /// Méthode "AjoutBoite"  
        /// </summary>
        /// <param name="b"> Boite de Jeu à ajouter </param>
        /// 
        /// Ajoute un utilisateur dans la liste "lesBoites"
        public void AjoutBoite(BoiteDeJeu b) 
        {
            if(!lesBoites.Contains(b))
                lesBoites.Add(b);
        }
    }
}
