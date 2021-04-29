using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Utilisateur : Nommable
    {
        private string motDePasse;
        private IList<Profil> profilsHybrides;
        private IList<Profil> profilsFavoris;
        public Utilisateur(string nom, string motDePasse) : base(nom)
        {
            profilsFavoris = new List<Profil>();
            profilsHybrides = new List<Profil>();
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

        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
        public IList<Profil> ProfilsHybrides { get => profilsHybrides; set => profilsHybrides = value; }
        public IList<Profil> ProfilsFavoris { get => profilsFavoris; set => profilsFavoris = value; }
    }
}
