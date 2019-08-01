using RentParser.Model;
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
        public TransactionDetailsView(Transaction transaction)
        {
            ViewModel = new TransactionDetailsViewModel(transaction);
            DataContext = ViewModel;
            InitializeComponent();
            sender_button.Content = (transaction.Payee!=null)?transaction.Payee.Name:transaction.PayeeLabel;
        }

        private void edit_sender(object sender, MouseButtonEventArgs e)
        {

        }

        private void Sender_button_Click(object sender, RoutedEventArgs e)
        {
            ParticipantDetailsViewModel viewModel = new ParticipantDetailsViewModel(ViewModel.Transaction);
            ParticipantDetailsView participantView = new ParticipantDetailsView(viewModel);
            participantView.Owner = this;
            participantView.Show();
            Console.WriteLine("Let's see");
            //Transaction selectedEntry = ((Transaction)((ListViewItem)sender).Content);
            //TransactionDetailsView detailsView = new TransactionDetailsView(selectedEntry);
            //detailsView.Owner = this;
            //detailsView.Show();
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
