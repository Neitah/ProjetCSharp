using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Utilisateur : Nommable
    {
        /// <summary>
        /// Mot de passe de l'utilisateur 
        /// </summary>
        public string MotDePasse { get; set; }


        /// <summary>
        /// Liste des profils hybrides de l'utilisateur 
        /// </summary>
        public IList<Profil> ProfilsHybrides { get; set; }

        /// <summary>
        /// Liste des profils favoris de l'utilisateur 
        /// </summary>
        public IList<Profil> ProfilsFavoris { get; set; }

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="nom"> Nom de l'utilisateur </param>
        /// <param name="motDePasse"> Mot de passe de l'utilisateur </param>
        public Utilisateur(string nom, string motDePasse) : base(nom)
        {
            ProfilsFavoris = new List<Profil>();
            ProfilsHybrides = new List<Profil>();
            MotDePasse = motDePasse;
        }

        /// <summary>
        /// Méthode "AjoutProfilhybride"  
        /// </summary>
        /// <param name="p"> Profil à ajouter </param>
        /// 
        /// Ajoute un profil hybride dans la liste " ProfilsHybrides"
        public void AjoutProfilHybride(Profil p)
        {
            if(!ProfilsHybrides.Contains(p))
                ProfilsHybrides.Add(p);
        }

        /// <summary>
        /// Méthode "AjoutProfilFavori"  
        /// </summary>
        /// <param name="p"> Profil à ajouter </param>
        /// 
        /// Ajoute un profil favori dans la liste " ProfilsFavoris"
        public void AjoutProfilFavori(Profil p)
        {
            if(!ProfilsFavoris.Contains(p))
                ProfilsFavoris.Add(p);
        }

        /// <summary>
        /// Méthode "SupprimerProfilFavorii"  
        /// </summary>
        /// <param name="p"> Profil à supprimer </param>
        /// 
        /// Supprime un profil favori de la liste " ProfilsFavoris"
        public void SupprimerProfilFavori(Profil p)
        {
            if (ProfilsFavoris.Contains(p) == false)
            {
                throw new Exception("$Le profil {p} n'est déja pas dans vos favori");
            }
            ProfilsFavoris.Remove(p);
        }

        /// <summary>
        /// Méthode "SupprimerProfilHybride"  
        /// </summary>
        /// <param name="p"> Profil à supprimer </param>
        /// 
        /// Supprime un profil hybride de la liste " ProfilsHybrides"
        public void SupprimerProfilHybride(Profil p)
        {
            if (ProfilsHybrides.Contains(p) == false)
            {
                throw new Exception("$Le profil {p} n'existe pas");
            }
            ProfilsHybrides.Remove(p);
        }

        /// <summary>
        /// Méthode "ToString"
        /// </summary>
        public override string ToString()
        {
            return $"{Nom} : {MotDePasse}";
        }

        /// <summary>
        /// Méthode "Equals"  
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Utilisateur utilisateur &&
                   MotDePasse == utilisateur.MotDePasse &&
                   EqualityComparer<IList<Profil>>.Default.Equals(ProfilsHybrides, utilisateur.ProfilsHybrides) &&
                   EqualityComparer<IList<Profil>>.Default.Equals(ProfilsFavoris, utilisateur.ProfilsFavoris) &&
                   Nom == utilisateur.Nom;
        }
    }
}
