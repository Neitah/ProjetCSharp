using System;

namespace ClassLibrary1

{
    public abstract class Nommable
    {
        private string nom;
        public Nommable(string nom)
        {
            Nom = nom;
        }

        public string Nom { get => nom; set => nom = value; }
    }
}
