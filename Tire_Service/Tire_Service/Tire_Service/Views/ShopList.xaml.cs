using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tire_Service.Classes;
using Xamarin.Forms;
using Tire_Service.Views;
using Tire_Service.ViewModels;
using Xamarin.Forms.Xaml;
using System.Runtime.InteropServices;

namespace Tire_Service.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopList : ContentPage
    {
        
        
        public ShopList()
        {
            InitializeComponent();
            ShopTovarList.ItemsSource = tovar.GetTovarList();
       
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();          
        }
        async internal void OnButtonClicked(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new RegisterPage());
        }
        async internal void TireClicked(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new TirePage());
        }
        private void DiskClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AboutPage());
        }
        async internal void ServiceClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ServicePage());
        }
    }
}