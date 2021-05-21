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
    public partial class AffichProfil : Window
    {
        Profil p;
        Utilisateur utilisateurActuel;
        public AffichProfil(Utilisateur utilisateurActuel, Profil p)
        {
            InitializeComponent();
            this.p = p;
            this.DataContext = p;
            voie1.ItemsSource = p.LesVoies[0].LesCompétences;
            voie2.ItemsSource = p.LesVoies[1].LesCompétences;
            voie3.ItemsSource = p.LesVoies[2].LesCompétences;
            voie4.ItemsSource = p.LesVoies[3].LesCompétences;
            voie5.ItemsSource = p.LesVoies[4].LesCompétences;
        }

        private void ClickFavori(object sender, RoutedEventArgs e)
        {
            if (utilisateurActuel.ProfilsFavoris.Contains(p))
            {
                ((Button)sender).Content = "Enlever des favoris";
                utilisateurActuel.SupprimerProfilFavori(p);
                ((Button)sender).Width = 160;
            }
            else
            {
                ((Button)sender).Content = "Favori";
                utilisateurActuel.AjoutProfilFavori(p);
                ((Button)sender).Width = 100;
            }
        }   
    }
}
