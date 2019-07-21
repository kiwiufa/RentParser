using RentParser.DataProvider;
using System.Collections.ObjectModel;

namespace RentParser.ViewModel
{
    public class MainViewModel
    {
        private TransactionDataProvider _transactionDataProvider;
        private TransactionEntry _selectedTransaction;
        public ObservableCollection<TransactionEntry> Transactions { get; }

        public MainViewModel()
        {
            _transactionDataProvider = new TransactionDataProvider();
            Transactions = new ObservableCollection<TransactionEntry>();
        }

        public void LoadTransactions()
        {
            Transactions.Clear();

            var transactions = _transactionDataProvider.LoadTransactionHistory();

            foreach (var transaction in transactions)
            {
                Transactions.Add(transaction);
            }
        }
    }
}
