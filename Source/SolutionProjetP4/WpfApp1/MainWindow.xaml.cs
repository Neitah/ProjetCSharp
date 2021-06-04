using ClassesApp;
using Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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
        private StockageApp sa = new ChargeurFic().Charger("donnees.bin");
        public Utilisateur UtilisateurActuel { get; set; }
        private ObservableCollection<Profil> Profils { get; set; }

      
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
                Window fenLogin = new PageConnexion(sa);
                fenLogin.Show();
            }
            else
            {
                Window fenCrePro = new CreationProfil(sa, UtilisateurActuel, this);
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
            Window fenLogin = new PageConnexion(sa);
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
            Window fen = new AffichProfil(UtilisateurActuel,(Profil)((ListBox)sender).SelectedItem);
            fen.Show();       
        }
      

        public void Update_ListBox ()
        {
            Profils.Clear();
            foreach (Profil p in UtilisateurActuel.ProfilsFavoris.OrderBy(profil => profil.Nom))
            {
                Profils.Add(p);
            }

            foreach (Profil p in UtilisateurActuel.ProfilsHybrides.OrderBy(profil => profil.Nom))
            {
                if (!Profils.Contains(p))
                    Profils.Add(p);
            }

            foreach (Profil p in sa.lesProfils.OrderBy(profil => profil.Nom))
            {
                if (!Profils.Contains(p))
                    Profils.Add(p);
            }

        }

        private void LienBoite1_Click(object sender, RoutedEventArgs e)
        {
            Process processfirefox = new Process();
            processfirefox = Process.Start("C:\\Program Files\\Mozilla Firefox\\firefox.exe", "https://www.amazon.fr/Black-Book-Chroniques-oubliees-Initiation/dp/B076N2MHHM/ref=sr_1_1?__mk_fr_FR=%C3%85M%C3%85%C5%BD%C3%95%C3%91&crid=2AOI1KWPDZJKL&dchild=1&keywords=chroniques+oubliees&qid=1622191520&sprefix=chroniques+oublie%2Caps%2C157&sr=8-1");
        }

        
        
           
        private void LienBoite2_Click(object sender, RoutedEventArgs e)
        {
            Process processfirefox = new Process();
            processfirefox = Process.Start("C:\\Program Files\\Mozilla Firefox\\firefox.exe", "https://www.amazon.fr/Black-Book-Chroniques-Oubli%C3%A9es-Initiation/dp/B089ZYS6R8/ref=bmx_1/258-1357005-3598317?pd_rd_w=AEF1j&pf_rd_p=dd759542-9066-427f-8f01-aa142ea8faac&pf_rd_r=S1GK02T6FJE0J7Z2MJH7&pd_rd_r=f77e1136-a90b-4066-aab1-326f10a0d1cf&pd_rd_wg=gddWJ&pd_rd_i=B089ZYS6R8&psc=1");

        }

        private void LienBoite3_Click(object sender, RoutedEventArgs e)
        {
            Process processfirefox = new Process();
            processfirefox = Process.Start("C:\\Program Files\\Mozilla Firefox\\firefox.exe", "https://www.amazon.fr/Black-Book-%C3%89ditions-Chroniques-Oubli%C3%A9es/dp/B07P882X5X/ref=sr_1_4?__mk_fr_FR=%C3%85M%C3%85%C5%BD%C3%95%C3%91&crid=309R3DAGCHXT8&dchild=1&keywords=chroniques+oubli%C3%A9es&qid=1622192128&sprefix=chroni%2Caps%2C175&sr=8-4");

        }
           
        private void BouttonSauver_Click(object sender, RoutedEventArgs e)
        {
            Sauveur.Sauver("donnees.bin", sa);
        }

      
    }
}