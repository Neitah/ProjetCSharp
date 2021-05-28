using ClassesApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
            try
            {
                Stream stream = File.Open(chemin, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                stock = (StockageApp)formatter.Deserialize(stream);
                stream.Close();
            }

            catch (Exception ex)
            {
                stock = new Stub().Charger("");
            }
            return stock;
        }
    }
}
