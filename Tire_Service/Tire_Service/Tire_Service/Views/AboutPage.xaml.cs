using System;
using System.ComponentModel;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tire_Service.Classes;
using Tire_Service.Views;
using System.Net.Http.Headers;

namespace Tire_Service.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            
            
            base.OnAppearing();
            DisksList.ItemsSource = DatabaseDisks.GetDisks();
        }
         async internal void TireClicked(object sender, EventArgs args) 
        {
            
            await Navigation.PushAsync(new TirePage());
        }
        async internal void ServiceClicked(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new ServicePage());
        }
        private void DiskSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                BrowseDisk(e.SelectedItem as Disks);
        }
        internal void BrowseDisk(Disks disk)
        {
            DiskBrowse db = new DiskBrowse();
            db.mydisk = disk;
            Navigation.PushAsync(db);
        }
    }
}