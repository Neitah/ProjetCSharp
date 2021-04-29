using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Compétence : Nommable
    {
        public string Description { get; set; }

        public Compétence(string description, string nom) : base(nom)
        {
            this.Description = description;
        }
    }
}
