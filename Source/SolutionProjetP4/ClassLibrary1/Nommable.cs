using System;

namespace ClassLibrary1

{
    public abstract class Nommable
    {
        public string Nom { get; set; }
        public Nommable(string nom)
        {
            Nom = nom;
        }
    }
}
