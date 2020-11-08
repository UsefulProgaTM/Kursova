using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Tire_Service.Classes;

namespace Tire_Service.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        internal tovar tov { get; set; }
        public AboutViewModel()
        {
           tov = new tovar();
        }
        public string nazva
        {
            get { return tov.nazva; }
            set
            {
                if (tov.nazva != value)
                {
                    tov.nazva = value;
                    OnPropertyChanged("nazva");
                }
            }
        }
        public int price
        {
            get { return tov.price; }
            set
            {
                if (tov.price != value)
                {
                    tov.price = value;
                    OnPropertyChanged("price");
                }
            }
        }
       



    }
}