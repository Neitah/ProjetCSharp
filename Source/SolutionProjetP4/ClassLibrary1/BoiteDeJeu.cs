using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class BoiteDeJeu : Nommable
    {
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
        public BoiteDeJeu(string description,string nomMagasin, string nom) : base(nom)
        {
            Description = description;
            NomMagasin = nomMagasin;
        }

        /// <summary>
        /// Méthode "ToString"
        /// </summary>
        public override string ToString()
        {
            return $"{Nom} + {NomMagasin} : {Description}";
        }
    }
}
