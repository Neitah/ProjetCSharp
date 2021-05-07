using ClassesApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class ChargeurFic : Chargeur
    {
        /// <summary>
        /// Méthode de chargement des données depuis un fichier
        /// </summary>
        /// <param name="chemin">Chemin d'accès aux données</param>
        /// <returns name="stock">Ensemble des données se trouvant dans le fichier</returns>
        public override StockageApp Charger(string chemin)
        {
            StockageApp stock = new StockageApp();
            return stock;
        }
    }
}
