using System;
using System.Collections.Generic;
using System.Text;
    
namespace ClassLibrary1
{   
    class Voie : Nommable
    {
        public IList<Compétence> LesCompétences { get; set; }
    
        public Voie(string nom) : base(nom)
        {
            LesCompétences = new List<Compétence>();
        }

        public void AjoutCompétence(Compétence c)
        {
            if (LesCompétences.Count<5)
                LesCompétences.Add(c);
            else
                throw new Exception("Une Voie ne peut contenir que 5 compétences");
        }
    }
}   
