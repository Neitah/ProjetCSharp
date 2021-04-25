﻿using System;
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
    public partial class Window1 : Window
    {
        private static int fav = 0;
        public Window1()
        {
            InitializeComponent();
        }

        private void ClickFavori(object sender, RoutedEventArgs e)
        {
            if (fav == 0)
            {
                ((Button)sender).Content = "Enlever des favoris";
                fav = 1;
            }
            else
            {
                ((Button)sender).Content = "Favori";
                fav = 0;
            }
        }   
    }
}