using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            
            

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

           

            if ((string.IsNullOrEmpty(Username.Text) || (string.IsNullOrWhiteSpace(Username.Text))))
            {
                DisplayAlert("Alert", "There is no content in username. Try again.", "Retry");
            }
            else
            {
                if ((string.IsNullOrEmpty(Password.Text) || (string.IsNullOrWhiteSpace(Password.Text))))
                {
                    DisplayAlert("Alert", "There is no content in password. Try again.", "Retry");
                }
                else
                {
                    DisplayAlert("Welcome", $"Hi {Username.Text}", "Ok");
                }
            }
            

            

            

            //DisplayAlert("Test", "Hello", "Ok");

        }

        
    }
}