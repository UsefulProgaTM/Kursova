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
    public partial class ServicePage : ContentPage
    {
       
        public ServicePage()
        {

            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {


            base.OnAppearing();
            ServiceList.ItemsSource = DatabaseService.GetService();
        }
        async internal void TireClicked(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new TirePage());
        }
        async internal void DisksClicked(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new AboutPage());
        }
        private void ServiceSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                BrowseServicefunc(e.SelectedItem as Service);
        }
        internal void BrowseServicefunc(Service serv)
        {
            BrowseService bs = new BrowseService();
            bs.myservice = serv;
            Navigation.PushAsync(bs);
        }
    }
}