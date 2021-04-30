using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Compétence : Nommable
    {
        /// <summary>
        /// Description de la compétence 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="description"> Description de la compétence </param>
        /// <param name="nom"> Nom de la compétence </param>
        public Compétence(string description, string nom) : base(nom)
        {
            this.Description = description;
        }

        /// <summary>
        /// Méthode "ToString"
        /// </summary>
        public override string ToString()
        {
            return $"{Nom} : {Description}";
        }

        /// <summary>
        /// Méthode "Equals"  
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Compétence compétence &&
                   Description == compétence.Description &&
                   Nom == compétence.Nom;
        }
    }
}
