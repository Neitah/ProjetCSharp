using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    [Serializable]
    public class BoiteDeJeu : Nommable
    {
        /// <summary>
        /// Chemin d'accés à l'image de la boite de jeu 
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Description de la boite de jeu
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Nom du magasin de la boite de jeu
        /// </summary>
        public string NomMagasin { get; set; }

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="description"> Description de la boite de jeu </param>
        /// <param name="nomMagasin"> Nom du magasin de la boite de jeu </param>
        /// <param name="nom"> Nom de la boite de jeu </param>
        /// <param name="image"> Chemin d'accès de l'image de la boite de jeu </param>
        public BoiteDeJeu(string description,string nomMagasin, string nom, string image) : base(nom)
        {
            Description = description;
            NomMagasin = nomMagasin;
            Image = image;
        }

        /// <summary>
        /// Méthode "ToString"
        /// </summary>
        public override string ToString()
        {
            return $"{Nom} + {NomMagasin} : {Description} / {Image}";
        }

        /// <summary>
        /// Méthode "Equals"  
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is BoiteDeJeu jeu &&
                   Description == jeu.Description &&
                   NomMagasin == jeu.NomMagasin &&
                   Nom == jeu.Nom &&
                   Image == jeu.Image;
        }
    }
}
