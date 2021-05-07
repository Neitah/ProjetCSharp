using System;

namespace ClassesApp

{
    public abstract class Nommable
    {

        /// <summary>
        /// Nom d'un Objet 
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"> Nom d'un Objet </param>
        public Nommable(string nom)
        {
            Nom = nom;
        }
    }
}
