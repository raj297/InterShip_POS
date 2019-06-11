using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MyPOS.Models;
using MyPOS.ViewModels;

namespace MyPOS.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ReceiptDetailPage : ContentPage
    {
        ReceiptDetailViewModel viewModel;

        public ReceiptDetailPage(ReceiptDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ReceiptDetailPage()
        {
            InitializeComponent();

            var receipt = new Receipt
            {
                Name = "#1-1000",
                TransactionDate = DateTime.Now,
                Total = 1800
            };

            viewModel = new ReceiptDetailViewModel(receipt);
            BindingContext = viewModel;
        }
    }
}