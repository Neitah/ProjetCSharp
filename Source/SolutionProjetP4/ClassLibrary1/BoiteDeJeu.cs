using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class BoiteDeJeu : Nommable
    {
        public string Description { get; set; }
        public string NomMagasin { get; set; }
        public BoiteDeJeu(string description,string nomMagasin, string nom) : base(nom)
        {
            Description = description;
            NomMagasin = nomMagasin;
        }
    }
}
