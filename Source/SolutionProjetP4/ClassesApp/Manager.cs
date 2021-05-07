using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class Manager
    {
        public StockageApp stockage;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="stockage">instance de la classes StockageApp sur lequel les méthodes vont agir</param>
        public Manager(StockageApp stockage)
        {
            this.stockage = stockage;
        }

        /// <summary>
        /// Méthode permettant la sauvegarde des données
        /// </summary>
        public void Sauvegarder()
        {
            ;
        }
    }
}
