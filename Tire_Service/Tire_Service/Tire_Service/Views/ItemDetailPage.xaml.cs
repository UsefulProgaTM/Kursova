using System.ComponentModel;
using Xamarin.Forms;
using Tire_Service.ViewModels;
using Tire_Service.Classes;

namespace Tire_Service.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}