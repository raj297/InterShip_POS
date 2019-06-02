using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
            //MessageBox.Show(ItemId.Text);
            ListBox.Items.Add(new { Id = ItemId.Text, Cost = "10" });
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var sum = 0;
            for (int i = 0; i < ListBox.Items.Count; ++i)
            {
                //(decimal.Parse((tblData.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text))
                sum += (int)decimal.Parse((ListBox.Columns[1].GetCellContent(ListBox.Items[i]) as TextBlock).Text);
            }
            Total.Text = "" + sum +"$";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

