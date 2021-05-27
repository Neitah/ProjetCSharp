using ClassesApp;
using Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StockageApp sa = new Stub().Charger("");
        public Utilisateur UtilisateurActuel { get; set; }
        public IList<Profil> Profils { get; set; }



        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = sa;
            Profils = new ObservableCollection<Profil>();
            UtilisateurActuel = null;
            foreach (Profil p in sa.lesProfils)
                Profils.Add(p);
            LBprofils.ItemsSource = Profils;
            Boite1.DataContext = sa.lesBoites[0];
            Boite2.DataContext = sa.lesBoites[1];
            Boite3.DataContext = sa.lesBoites[2];
            UtilisateurConnecte.DataContext = UtilisateurActuel;
    
        }

        private void CréationProfilHybride_Click(object sender, RoutedEventArgs e)
        {
            if (UtilisateurActuel == null)
            {
                Window fenLogin = new PageConnexion(sa, this);
                fenLogin.Show();
            }
            else
            {
                Window fenCrePro = new CreationProfil(sa, UtilisateurActuel);
                fenCrePro.Show();
            }
        }

        private void BoutInscription_Click(object sender, RoutedEventArgs e)
        {
            Window fenInscription = new PageInscription(sa, this);
            fenInscription.Show();
        }

        private void BoutConnexion_Click(object sender, RoutedEventArgs e)
        {
            Window fenLogin = new PageConnexion(sa, this);
            fenLogin.Show();
        }

        public void UtilConnecte(Utilisateur nouvUtil)
        {
            UtilisateurActuel = nouvUtil;
            UtilisateurConnecte.DataContext = UtilisateurActuel;
            Update_ListBox();
            
        }

        private void LBprofils_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window fen = new AffichProfil(UtilisateurActuel,(Profil)((ListBox)sender).SelectedItem, this);
            fen.Show();
        }

        public void Update_ListBox ()
        {
            Profils.Clear();
            foreach (Profil p in UtilisateurActuel.ProfilsFavoris)
            {
                Profils.Add(p);
            }

            foreach (Profil p in sa.lesProfils)
            {
                if (!Profils.Contains(p))
                    Profils.Add(p);
            }

            foreach (Profil p in UtilisateurActuel.ProfilsHybrides)
            {
                if (!Profils.Contains(p))
                    Profils.Add(p);
            }

        }
    }
}
