using ClassesApp;
using Data;
using System;
using System.Collections.Generic;
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
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = sa;
            LBprofils.ItemsSource = sa.lesProfils;
            Boite1.DataContext = sa.lesBoites[0];
            Boite2.DataContext = sa.lesBoites[1];
            Boite3.DataContext = sa.lesBoites[2];
        }

        private void CréationProfilHybride_Click(object sender, RoutedEventArgs e)
        {
            Window fenCrePro=new CreationProfil();
            fenCrePro.Show();           
        }

        private void BoutInscription_Click(object sender, RoutedEventArgs e)
        {
            Window fenInscription = new PageInscription(sa);
            fenInscription.Show();
        }

        private void BoutConnexion_Click(object sender, RoutedEventArgs e)
        {
            Window fenLogin = new PageConnexion(sa);
            fenLogin.Show();
        }
    }
}
