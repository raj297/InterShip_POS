using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MyPOS.Models;
using MyPOS.Views;
using MyPOS.ViewModels;

namespace MyPOS.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class PaymentPage : ContentPage
    {
        PaymentViewModel viewModel;

        public PaymentPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PaymentViewModel();
        }
        
        //async void SplitPayment_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushModalAsync(new NavigationPage(new SplitPaymentPage()));
        //}
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}