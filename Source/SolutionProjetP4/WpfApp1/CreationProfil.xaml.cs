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
        Profil p;
        List<Voie> lesVoies;
        MainWindow mw;

        public CreationProfil(StockageApp sa, Utilisateur utilisateurActuel, MainWindow mw)
        {
            InitializeComponent();
            this.sa = sa;
            this.mw = mw;
            this.utilisateurActuel = utilisateurActuel;
            lesVoies = new List<Voie>();
            txtProfil1.DataContext = sa.lesProfils[0];
            liste1.ItemsSource = sa.lesProfils[0].LesVoies;

            txtProfil2.DataContext = sa.lesProfils[1];
            liste2.ItemsSource = sa.lesProfils[1].LesVoies;

            txtProfil3.DataContext = sa.lesProfils[2];
            liste3.ItemsSource = sa.lesProfils[2].LesVoies;

            txtProfil4.DataContext = sa.lesProfils[3];
            liste4.ItemsSource = sa.lesProfils[3].LesVoies;

            txtProfil5.DataContext = sa.lesProfils[4];
            liste5.ItemsSource = sa.lesProfils[4].LesVoies;

            txtProfil6.DataContext = sa.lesProfils[5];
            liste6.ItemsSource = sa.lesProfils[5].LesVoies;

            txtProfil7.DataContext = sa.lesProfils[6];
            liste7.ItemsSource = sa.lesProfils[6].LesVoies;

            txtProfil8.DataContext = sa.lesProfils[7];
            liste8.ItemsSource = sa.lesProfils[7].LesVoies;

            txtProfil9.DataContext = sa.lesProfils[8];
            liste9.ItemsSource = sa.lesProfils[8].LesVoies;

            txtProfil10.DataContext = sa.lesProfils[9];
            liste10.ItemsSource = sa.lesProfils[9].LesVoies;

            txtProfil11.DataContext = sa.lesProfils[10];
            liste11.ItemsSource = sa.lesProfils[10].LesVoies;

            txtProfil12.DataContext = sa.lesProfils[11];
            liste12.ItemsSource = sa.lesProfils[11].LesVoies;

            txtProfil13.DataContext = sa.lesProfils[12];
            liste13.ItemsSource = sa.lesProfils[12].LesVoies;

            txtProfil14.DataContext = sa.lesProfils[13];
            liste14.ItemsSource = sa.lesProfils[13].LesVoies;
        }



        private void BoutCreationHybride_Click(object sender, RoutedEventArgs e)
        {
            if (NomProfil.Text.Trim().Equals("") || DeVie.Text.Trim().Equals("") || Equipement.Text.Trim().Equals(""))
            {
                MessageErreur.Text = "Champ(s) obligatoire(s) non rempli(s)";
            }
            else
            {
                p = new Profil(NomProfil.Text, DeVie.Text, Equipement.Text, ArmesEtArmures.Text, Divers.Text, Description.Text,"");
                foreach (Voie v in lesVoies)
                    p.AjoutVoie(v);
                utilisateurActuel.AjoutProfilHybride(p);
                mw.Update_ListBox();
                this.Close();
            }

        }

        private void BoutValidProfParent_Click(object sender, RoutedEventArgs e)
        {
            int nbVoies=lesVoies.Count;
            if(nbVoies==5)
            {
                BoutCreationHybride.IsEnabled = true;
                liste1.IsEnabled = false;
                liste2.IsEnabled = false;
            }
            else
            {
                ErreurVoies.Text = "Veuillez sélectionner 5 voies";
            }
        }

        private void Voie_CheckedChange(object sender, RoutedEventArgs e)
        {
            Voie voie = (Voie)(((CheckBox)sender).DataContext);
            if (lesVoies.Contains(voie))
            {
                lesVoies.Remove(voie);
            }
            else
            {
                lesVoies.Add(voie);
            }
        }
    }
}
