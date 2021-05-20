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
    /// Logique d'interaction pour PageInscription.xaml
    /// </summary>
    public partial class PageInscription : Window
    {
        StockageApp sa;
        Utilisateur utilisateurActuel;
        public PageInscription(StockageApp sa,Utilisateur utilisateurActuel)
        {
            InitializeComponent();
            this.sa = sa;
        }

        private void BoutValidInscription_Click(object sender, RoutedEventArgs e)
        {
            bool err = false;
            if (Login.Text.Trim().Equals(""))
            {
                Erreur1.Text = "Veuillez entrer un login";
                err = true;
            }
            else
            {
                Erreur1.Text = "";
                err = false; 
            }

            if(MotDePasse.Password.Equals(""))
            {
                Erreur2.Text = "Veuillez entrer un Mot De Passe";
                err = true;
            }
            else if (!MotDePasse.Password.Equals(MotDePasseVerif.Password))
            {
                Erreur2.Text = "Les deux mots de passe ne sont pas identiques";
                err = true;
            }

            if (!err)
            {
                utilisateurActuel = new Utilisateur(Login.Text, MotDePasse.Password);
                sa.AjoutUtilisateur(utilisateurActuel);
                this.Close();
            }
        }
    }
}
