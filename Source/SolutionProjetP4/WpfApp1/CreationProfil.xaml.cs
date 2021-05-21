using ClassesApp;
using Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class CreationProfil : Window
    {
        StockageApp sa;
        Utilisateur utilisateurActuel;
        static IList<Boolean> lesBoutons = new List<Boolean>() ;

        public CreationProfil(StockageApp sa, Utilisateur utilisateurActuel)
        {
            InitializeComponent();
            this.sa = sa;
            this.utilisateurActuel = utilisateurActuel;
            for (int i = 0; i < 14; ++i)
                lesBoutons.Add(false);
            bouton1.DataContext = sa.lesProfils[0];
        }

        private void Profil_Click(object sender, RoutedEventArgs e)
        {
            String num=((Button)sender).Name.Remove(0, 6);
            
            if (lesBoutons[0] == false)
            {
                liste1.ItemsSource = sa.lesProfils[0].LesVoies;
                lesBoutons[0] = true;
            }
            else
            {
                liste1.ItemsSource = null;
                lesBoutons[0] = false;
            }
        }
    }
}
