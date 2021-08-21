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

        private async void OnButtonClicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(usernameEntry.Text))
            {
                await DisplayAlert("Alert", "There is no content in username. Try again.", "Retry");
            }
            else if (string.IsNullOrEmpty(passwordEntry.Text))
            {
                 await DisplayAlert("Alert", "There is no content in password. Try again.", "Retry");
            }
            else
            {
                 await DisplayAlert("Welcome", $"Hi {usernameEntry.Text}", "Ok");
            }

            
        }

        
    }
}