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
using TPGarage.Client.Models;

namespace TPGarage.Client.Views
{
    /// <summary>
    /// Logique d'interaction pour BrandFormBinding.xaml
    /// </summary>
    public partial class BrandFormBinding : UserControl
    {

        private ObservableCollection<Brand> _Brands;

        public BrandFormBinding()
        {
            InitializeComponent();

            _Brands = new ObservableCollection<Brand>()
            {
                new Brand() {Name = "Opel"},
                new Brand() {Name = "Citroen"},
                new Brand() {Name = "Renault"}
            };

            Brand b = new Brand() { Name = "Kia" };
            b.Models.Add(new Model(){ Name = "Rio" });
            b.Models.Add(new Model(){ Name = "Picanto" });

            _Brands.Add(b);
            
            _BrandList.ItemsSource = this._Brands;

            /*
             * this._Brands.Add(new Brand() { Name = "Opel" });
            this._Brands.Add(new Brand() { Name = "Citroen" });
            this._Brands.Add(new Brand() { Name = "Renault" });
            */
        }

        public void AddBrand()
        {
            _Brands.Add(new Brand() { Name = "Nouveau" });
        }

        public void DeleteSelectedBrand()
        {
            if(this._BrandList.SelectedItem is Brand brand)
            {
                _Brands.Remove(brand);

            }
        }

        public void AddModel()
        {
            //_Brands.Add(new Brand() { Name = "Nouveau" });
        }

        public void DeleteSelectedModel()
        {
            if(this._BrandList.SelectedItem is Brand brand)
            {
                //_Brands.Remove(brand);

            }
        }

        private void DeleteModelButton_Click(object sender, RoutedEventArgs e)
        {

            if (this._BrandList.SelectedItem is Brand brand)
            {
                foreach (Model model in DataGridModels.SelectedItems.OfType<Model>().ToList())
                {
                    if (brand.Models.Contains(model))
                    {
                        brand.Models.Remove(model);
                    }
                }

            }
        }

        private void AddModelButton_Click(object sender, RoutedEventArgs e)
        {
            if (this._BrandList.SelectedItem is Brand brand)
            {
                brand.Models.Add(new Model() { Name = "nouveau" });
            }
        }
    }
}
