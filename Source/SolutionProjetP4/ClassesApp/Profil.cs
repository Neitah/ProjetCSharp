using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    [Serializable]
    public class Profil : Nommable, IEquatable<object>
    {
        /// <summary>
        /// Chemin d'accés à l'image du profil
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Liste contenant les Voies de ce profil
        /// </summary>
        public IList<Voie> LesVoies { get; set; }

        /// <summary>
        /// Dé de vie du profil
        /// </summary>
        public string DéVie { get; set; }

        /// <summary>
        /// Equipement du profil
        /// </summary>
        public string Equipement { get; set; }

        /// <summary>
        /// Armes et armures du profil
        /// </summary>
        public string ArmeEtArmures { get; set; }

        /// <summary>
        /// Option divers du profil (passif, compagnon, ...) 
        /// </summary>
        public string Divers { get; set; }

        /// <summary>
        /// Description de la manière de jouer du profil 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="nom"> Nom du profil </param>
        /// <param name="déVie"> Dé de vie du profil </param>
        /// <param name="equipement"> Equipement du profil </param>
        /// <param name="armeEtArmures"> Armes et armures du profil </param>
        /// <param name="divers"> Option divers du profil (passif, compagnon, ...) </param>
        /// <param name="image"> Chemin d'accés à l'image du profil </param>
        public Profil(string nom,string déVie, string equipement, string armeEtArmures, string divers, string description, string image) : base(nom)
        {
            LesVoies = new List<Voie>();
            DéVie = déVie;
            Equipement = equipement;
            ArmeEtArmures = armeEtArmures;
            Divers = divers;
            Description = description;
            Image = image;
        }

        /// <summary>
        /// Méthode "AjoutVoie"  
        /// </summary>
        /// <param name="v"> Voie à ajouter </param>
        /// 
        /// Ajoute une Voie dans la liste "LesVoies"
        public void AjoutVoie(Voie v)
        {
            if (LesVoies.Contains(v))
                return; 
            if (LesVoies.Count < 5)
                LesVoies.Add(v);
            else
                throw new Exception("Un profil ne peut pas avoir plus de 5 voies");
        }


        /// <summary>
        /// Méthode "ToString"
        /// </summary>
        public override string ToString()
        {
            String s = "";
            for (int i = 0; i < LesVoies.Count; i++)
            {
                s += $"\n\t{LesVoies[i]}";
            }
            return $"{Nom} : {DéVie} / {Equipement} / {ArmeEtArmures} / {Divers} / {Image}\n{s}";
        }

        /// <summary>
        /// Méthode "Equals"  
        /// </summary>
        public override bool Equals(object obj)
        {
            Profil profil = (Profil)obj;
            bool ret = DéVie == profil.DéVie &&
                   Equipement == profil.Equipement &&
                   ArmeEtArmures == profil.ArmeEtArmures &&
                   Divers == profil.Divers &&
                   Description == profil.Description &&
                   Nom == profil.Nom &&
                   Image == profil.Image; ;
            for (int i = 0; i<LesVoies.Count;i++)
            {
                if (!LesVoies[i].Equals(profil.LesVoies[i]))
                    ret = false;
            }
            return ret;
        }
    }
}
