using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using MyPOS.Models;
using MyPOS.Views;

namespace MyPOS.ViewModels
{
    public class PaymentViewModel: BaseViewModel
    {
        public PaymentViewModel()
        {
            Title = "Charge";
        }
    }
}
