using ClassesApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public abstract class Chargeur
    {
        /// <summary>
        /// Méthode permettant de charger des données
        /// </summary>
        /// <param name="chemin">chemin d'accès de l'endroit où se trouvent les données</param>
        public abstract StockageApp Charger(string chemin);
    }
}
