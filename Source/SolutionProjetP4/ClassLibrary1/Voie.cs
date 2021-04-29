using System;
using System.Collections.Generic;
using System.Text;
    
namespace ClassLibrary1
{   
    public class Voie : Nommable
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

        public override bool Equals(object voie)
        {
            return base.Equals(voie);
        }
        public override string ToString()
        {
            String s="";
            for(int i=0;i < LesCompétences.Count; i++)
            {
                s += $"\n\t{LesCompétences[i]}";
            }
            return $"{Nom} --> {s}";
        }
    }
}   
