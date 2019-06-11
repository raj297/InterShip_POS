using System;

using MyPOS.Models;

namespace MyPOS.ViewModels
{
    public class ReceiptDetailViewModel : BaseViewModel
    {
        public Receipt Receipt { get; set; }
        public ReceiptDetailViewModel(Receipt receipt = null)
        {
            Title = receipt?.Name;
            Receipt = receipt;
        }
    }
}
