using RentParser.DataProvider;
using RentParser.Model;
using System;
using System.Collections.ObjectModel;

namespace RentParser.ViewModel
{
    public class MainViewModel
    {
        private static string _categoryFilename = "Categories.json";
        private static string _participantsFilename = "Participants.json";

        private IDataProvider<Category> _categoryProvier;
        private IDataProvider<Participant> _participantProvier;
        private TransactionDataProvider _transactionDataProvider;
        private TransactionEntry _selectedTransaction;
        public ObservableCollection<Transaction> Transactions { get; }
        public ObservableCollection<Participant> Participants { get; set;}
        public ObservableCollection<Category> Categories { get; set;}

        public MainViewModel()
        {
            _categoryProvier = new DataProvider<Category>(_categoryFilename);
            _participantProvier = new DataProvider<Participant>(_participantsFilename);
            _transactionDataProvider = new TransactionDataProvider();
            Transactions = new ObservableCollection<Transaction>();
        }

        public async void LoadModels()
        {
            Categories = new ObservableCollection<Category>(await _categoryProvier.LoadElementsAsync());
            Participants = new ObservableCollection<Participant>(await _participantProvier.LoadElementsAsync());
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
