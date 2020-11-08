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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            
            InitializeComponent();
        }
        private void OnRegisterClicked(object sender, EventArgs args)
        {
            string name, surname, auto, phone;
            name = Name.Text;
            surname = SurName.Text;
            auto = SurName.Text;
            phone = Phone.Text;
            if (name != null && surname != null && auto != null && phone != null)
            {
                
                    Register.RecordUser(phone, name, surname, auto);
                    Register.RecordOrder();
                    DisplayAlert("Увага", "Ваше замовлення скоро буде оброблено! Ми вам передзвонимо!", "OK");
               

            }
            else {
                DisplayAlert("Увага", "pizdec", "OK");
            }
            
        }
       
    }
}