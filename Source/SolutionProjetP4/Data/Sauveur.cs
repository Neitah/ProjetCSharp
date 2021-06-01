using ClassesApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Data
{
    public static class Sauveur
    {
        public static void Sauver (string chemin, StockageApp stock)
        {
            Stream stream= File.Open(chemin,FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, stock);
            stream.Close();
        }
    }
}
