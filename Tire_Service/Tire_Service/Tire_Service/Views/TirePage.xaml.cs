using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tire_Service.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tire_Service.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TirePage : ContentPage
    {
        public TirePage()
        {
            InitializeComponent();
           
        }
        protected override void OnAppearing()
        {


            base.OnAppearing();
            TiresList.ItemsSource = TiresDatabase.GetTires();
        }
        private void TireSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                BrowseTire(e.SelectedItem as Tires);
        }
        async internal void ServiceClicked(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new ServicePage());
        }
        private void DiskClicked(object sender, EventArgs args) 
        {
           Navigation.PushAsync(new AboutPage());
        }
        void BrowseTire(Tires tire)
        {
            TireBrowse db = new TireBrowse();
            db.mytire = tire;
            Navigation.PushAsync(db);
        }
    }
}