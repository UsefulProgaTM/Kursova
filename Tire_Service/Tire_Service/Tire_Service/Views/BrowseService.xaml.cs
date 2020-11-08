using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tire_Service.Classes;
using Tire_Service.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tire_Service.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowseService : ContentPage
    {
        internal  Service myservice;
        public BrowseService()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = this.myservice;
        }
        private void ServiceBuyClicked(object sender, EventArgs args)
        {
            tovar tov = new tovar();
            tov.CastToTovar(this.myservice);
            //DatabaseService.AddToServiceBuyList(this.myservice);
            DisplayAlert("Увага", "Послугу успішно замовлено", "OK");
        }
    }
}