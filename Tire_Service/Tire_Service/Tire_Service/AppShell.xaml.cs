using System;
using System.Collections.Generic;
using Tire_Service.ViewModels;
using Tire_Service.Views;
using Xamarin.Forms;

namespace Tire_Service
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(ShopList), typeof(ShopList));
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
