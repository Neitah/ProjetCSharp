using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Utilisateur : Nommable
    {
        public string MotDePasse { get; set; }
        public IList<Profil> ProfilsHybrides { get; set; }
        public IList<Profil> ProfilsFavoris { get; set; }


        public Utilisateur(string nom, string motDePasse) : base(nom)
        {
            ProfilsFavoris = new List<Profil>();
            ProfilsHybrides = new List<Profil>();
            MotDePasse = motDePasse;
        }

        public void AjoutProfilHybride(Profil p)
        {
            ProfilsHybrides.Add(p);
        }

        public void AjoutProfilFavori(Profil p)
        {
            ProfilsFavoris.Add(p);
        }

        public void SupprimerProfilFavori(Profil p)
        {
            ProfilsFavoris.Remove(p);
        }
    }
}
