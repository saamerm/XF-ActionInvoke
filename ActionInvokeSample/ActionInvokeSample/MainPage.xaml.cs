using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ActionInvokeSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var viewModel = new MainViewModel();
            BindingContext = viewModel;
            viewModel.OnLoginFailed = ((obj) =>
            {
                PasswordEntry.Focus();
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Makes the PasswordEntry get the focus on page load
            PasswordEntry.Focus();
        }
    }
}
