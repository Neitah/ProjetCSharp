using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Profil : Nommable
    {
        public IList<Voie> LesVoies { get; set; }
        public string DéVie { get; set; }
        public string Equipement { get; set; }
        public string ArmeEtArmures { get; set; }
        public string Divers { get; set; }

        public Profil(string nom,string déVie, string equipement, string armeEtArmures, string divers) : base(nom)
        {
            LesVoies = new List<Voie>();
            this.DéVie = déVie;
            this.Equipement = equipement;
            this.ArmeEtArmures = armeEtArmures;
            this.Divers = divers;
        }

        public void AjoutVoie(Voie v)
        {
            if (LesVoies.Count < 5)
                LesVoies.Add(v);
            else
                throw new Exception("Un profil ne peut pas avoir plus de 5 voies");
        }

        public override string ToString()
        {
            String s = "";
            for (int i = 0; i < LesVoies.Count; i++)
            {
                s += $"\n\t{LesVoies[i]}";
            }
            return $"{Nom} : {DéVie} / {Equipement} / {ArmeEtArmures} / {Divers} \n{s}";
        }
    }
}
