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
        public AffichProfil(Utilisateur utilisateurActuel, Profil p)
        {
            InitializeComponent();
            this.p = p;
            if (((MainWindow)((App)App.Current).MainWindow).UtilisateurActuel == null)
            {
                BoutAjoutFavori.Visibility = Visibility.Hidden;
            }
            else if (((MainWindow)((App)App.Current).MainWindow).UtilisateurActuel.ProfilsFavoris.Contains(p))
            {
                BoutAjoutFavori.Content = "Enlever des favoris";
                BoutAjoutFavori.Width = 160;
            }
            else
            {
                BoutAjoutFavori.Content = "Favori";
                BoutAjoutFavori.Width = 100;
            }
            this.DataContext = p;
            voie1.ItemsSource = p.LesVoies[0].LesCompétences;
            voie2.ItemsSource = p.LesVoies[1].LesCompétences;
            voie3.ItemsSource = p.LesVoies[2].LesCompétences;
            voie4.ItemsSource = p.LesVoies[3].LesCompétences;
            voie5.ItemsSource = p.LesVoies[4].LesCompétences;
            
        }

        private void ClickFavori(object sender, RoutedEventArgs e)
        {
            if (!((MainWindow)((App)App.Current).MainWindow).UtilisateurActuel.ProfilsFavoris.Contains(p))
            {
                ((Button)sender).Content = "Enlever des favoris";
                ((MainWindow)((App)App.Current).MainWindow).UtilisateurActuel.AjoutProfilFavori(p);
                ((Button)sender).Width = 160;
            }
            else
            {
                ((Button)sender).Content = "Favori";
                ((MainWindow)((App)App.Current).MainWindow).UtilisateurActuel.SupprimerProfilFavori(p);
                ((Button)sender).Width = 100;
            }
            ((MainWindow)((App)App.Current).MainWindow).Update_ListBox(); 
        }

        private void voie_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window fen = new AffichComp((Compétence)((ListBox)sender).SelectedItem);
            fen.Show();
        }

        private void voie_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                Window fen = new AffichComp((Compétence)((ListBox)sender).SelectedItem);
                fen.Show();
            }
        }

        private void voie_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            ((ListBox)sender).SelectedItem = ((ListBox)sender).Items[0];
        }
    }
}