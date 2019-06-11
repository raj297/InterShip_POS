using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MyPOS.Models;

namespace MyPOS.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewCustomerPage : ContentPage
    {
        public Customer Customer { get; set; }

        public NewCustomerPage()
        {
            InitializeComponent();

            Customer = new Customer
            {
                Name = "Customer name",
                Email = "",
                Number = 000000000,
                Note = ""
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddCustomer", Customer);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}