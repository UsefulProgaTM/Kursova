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
    public partial class TireBrowse : ContentPage
    {
        internal Tires mytire;
        
        public TireBrowse()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = this.mytire;
        }
        private void TireBuyClicked(object sender, EventArgs args)
        {
            tovar tov = new tovar();
            tov.CastToTovar(this.mytire);
            //TiresDatabase.AddToTireBuyList(this.mytire);
            DisplayAlert("Увага","Шина успішно куплена","OK");
        }

       
    }
}