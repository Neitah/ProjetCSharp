using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Compétence : Nommable
    {
        public string Description { get; set; }

        public Compétence(string description, string nom) : base(nom)
        {
            this.Description = description;
        }

        public override bool Equals(object compétence)
        {
            return base.Equals(compétence);
        }
        public override string ToString()
        {
            return $"{Nom} : {Description}";
        }
    }
}
