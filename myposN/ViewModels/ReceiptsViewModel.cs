using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using MyPOS.Models;
using MyPOS.Views;

namespace MyPOS.ViewModels
{
    public class ReceiptsViewModel : BaseViewModel
    {
        public ObservableCollection<Receipt> Receipts { get; set; }
        public Command LoadReceiptsCommand { get; set; }
        public ReceiptsViewModel()
        {
            Title = "Receipts";
            Receipts = new ObservableCollection<Receipt>();
            LoadReceiptsCommand = new Command(async () => await ExecuteLoadReceiptsCommand());
        }

        async Task ExecuteLoadReceiptsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Receipts.Clear();
                //var receipts = await DataStore.GetReceiptsAsync(true);
                //foreach (var receipt in receipts)
                //{
                //    Receipts.Add(receipt);
                //}
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
