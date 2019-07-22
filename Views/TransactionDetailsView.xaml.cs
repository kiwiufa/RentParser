using RentParser.ViewModel;
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

namespace RentParser.Views
{
    /// <summary>
    /// Interaction logic for TransactionDetailsView.xaml
    /// </summary>
    public partial class TransactionDetailsView : Window
    {
        public TransactionDetailsViewModel ViewModel { get; }
        public TransactionDetailsView(TransactionEntry transactionEntry)
        {
            ViewModel = new TransactionDetailsViewModel(transactionEntry);
            DataContext = ViewModel;
            InitializeComponent();
        }

        //MouseDoubleClick event handler for your textBox1
        private void payee_label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            String test = "test";
        }
        //private void PopulateControls() //TODO: Change to data bindings 
        //{
        //    date_label.Content = _viewModel.TransactionEntry.Date;
        //    //sender_label.Content = _viewModel.TransactionEntry.Payee;
        //    payee_label.Content = _viewModel.TransactionEntry.Payee;
        //    amount_label.Content = _viewModel.TransactionEntry.Amount;
        //}
    }
}
