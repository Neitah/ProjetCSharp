using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Profil : Nommable
    {
        private IList<Voie> lesVoies;
        private string déVie;
        private string equipement;
        private string armeEtArmures;
        private string divers;

        public Profil(string nom,string déVie, string equipement, string armeEtArmures, string divers) : base(nom)
        {
            LesVoies = new List<Voie>();
            this.DéVie = déVie;
            this.Equipement = equipement;
            this.ArmeEtArmures = armeEtArmures;
            this.Divers = divers;
        }

        public string DéVie { get => déVie; set => déVie = value; }
        public string Equipement { get => equipement; set => equipement = value; }
        public string ArmeEtArmures { get => armeEtArmures; set => armeEtArmures = value; }
        public string Divers { get => divers; set => divers = value; }
        public IList<Voie> LesVoies { get => lesVoies; set => lesVoies = value; }

        public void AjoutVoie(Voie v)
        {
            if (LesVoies.Count < 5)
                LesVoies.Add(v);
            else
                throw new Exception("Un profil ne peut pas avoir plus de 5 voies");
        }
    }
}
