using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Compétence : Nommable
    {
        private string description;

        public Compétence(string description, string nom) : base(nom)
        {
            this.description = description;
        }

        public string Description { get => description; set => description = value; }
    }
}
