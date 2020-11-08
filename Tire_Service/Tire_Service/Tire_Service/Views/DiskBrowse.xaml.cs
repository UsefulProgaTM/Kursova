using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tire_Service.Classes;
using Xamarin.Forms;
using Tire_Service.Views;
using Xamarin.Forms.Xaml;

namespace Tire_Service.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiskBrowse : ContentPage
    {
        internal Disks mydisk;
        public DiskBrowse()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            BindingContext = this.mydisk;
        }
        private void DiskBuyClicked(object sender, EventArgs args)
        {
            tovar tov = new tovar();
            tov.CastToTovar(this.mydisk);
            //DatabaseDisks.AddToDisksBuyList(this.mydisk);
            DisplayAlert("Увага", "Диск успішно куплений", "OK");
        }
    }
}