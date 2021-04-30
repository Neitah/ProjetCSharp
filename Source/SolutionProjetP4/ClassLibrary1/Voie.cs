using System;
using System.Collections.Generic;
using System.Text;
    
namespace ClassLibrary1
{   
    public class Voie : Nommable
    {
        /// <summary>
        /// Liste contenant les compétences de cette voie
        /// </summary>
        public IList<Compétence> LesCompétences { get; set; }

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="nom"> Nom de la voie </param>
        public Voie(string nom) : base(nom)
        {
            LesCompétences = new List<Compétence>();
        }

        /// <summary>
        /// Méthode "AjoutCompétence"  
        /// </summary>
        /// <param name="c"> Compétence à ajouter </param>
        /// 
        /// Ajoute une cométence dans la liste "LesCompétences"
        public void AjoutCompétence(Compétence c)
        {
            if (LesCompétences.Count<5)
                LesCompétences.Add(c);
            else
                throw new Exception("Une Voie ne peut contenir que 5 compétences");
        }

        /// <summary>
        /// Méthode "Equals"  
        /// </summary>
        public override bool Equals(object voie)
        {
            return base.Equals(voie);
        }

        /// <summary>
        /// Méthode "ToString"
        /// </summary>
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
