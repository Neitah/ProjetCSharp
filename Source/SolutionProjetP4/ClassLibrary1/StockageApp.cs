using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class StockageApp
    {
        public IList<Profil> lesProfils;
        public IList<Utilisateur> lesUtilisateurs;

        public StockageApp()
        {
            lesProfils = new List<Profil>();
            lesUtilisateurs = new List<Utilisateur>();
        }

        public void AjoutProfil(Profil p)
        {
            lesProfils.Add(p);
        }

        public void AjoutUtilisateur(Utilisateur u)
        {
            lesUtilisateurs.Add(u);
        }
    }
}
