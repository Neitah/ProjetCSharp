using ClassesApp;
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
    /// Logique d'interaction pour PageConnexion.xaml
    /// </summary>
    public partial class PageConnexion : Window
    {
        StockageApp sa;
        Utilisateur utilisateurActuel;
        public PageConnexion(StockageApp sa, Utilisateur utilisateurActuel)
        {
            InitializeComponent();
            this.sa = sa;
            this.utilisateurActuel = utilisateurActuel;
        }

        private void BoutValidConnexion_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur(Login.Text, MotDePasse.Password);
            if (!sa.lesUtilisateurs.Contains(utilisateur))
            {
                Erreur.Text = "Le Login ou le mot de passe est invalide";
            }
            else
            {
                utilisateurActuel = utilisateur;
                this.Close();
            }
        }
    }
}
