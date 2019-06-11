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
    public partial class ReceiptsPage : ContentPage
    {
        ReceiptsViewModel viewModel;

        public ReceiptsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ReceiptsViewModel();
        }

        async void OnReceiptSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var receipt = args.SelectedItem as Receipt;
            if (receipt == null)
                return;

            await Navigation.PushAsync(new ReceiptDetailPage(new ReceiptDetailViewModel(receipt)));

            // Manually deselect item.
            ReceiptsListView.SelectedItem = null;
        }

        async void AddCustomer_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewCustomerPage()));
        }

        async void Charge_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new PaymentPage()));
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Receipts.Count == 0)
                viewModel.LoadReceiptsCommand.Execute(null);
        }
    }
}