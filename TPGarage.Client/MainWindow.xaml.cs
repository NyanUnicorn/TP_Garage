using MahApps.Metro.Controls;
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

namespace TPGarage.Client
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void MenuItem_AddBrand_Click(object sender, RoutedEventArgs a)
        {
            if (_TabBrandFormBinding.IsSelected)
            {
                _BrandFormBinding.AddBrand();
            }
        }

        private void MenuItem_DeleteSelectedBrand_Click(object sender, RoutedEventArgs a)
        {
            if (_TabBrandFormBinding.IsSelected)
            {
                _BrandFormBinding.DeleteSelectedBrand();
            }
        }
    }
}
