using CsvHelper;
using RentParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentParser.DataProvider
{
    class TransactionDataProvider
    {
        private static readonly string _transactionFileName = "Rental-3JUN2017-to-3JUN2019.csv";
        //ImportFilename = "C:\\Repos\\RentParser\\Rental-3JUN2017-to-3JUN2019.csv"

        private Transaction ConvertToTransaction(TransactionEntry entry)
        {
            Transaction transaction = new Transaction();
            transaction.Amount = float.Parse(entry.Amount, System.Globalization.NumberStyles.Currency);
            transaction.Date = DateTime.Parse(entry.Date);
            transaction.Payee = null;
            transaction.PayeeLabel = entry.Payee;
            transaction.Particulars = entry.Particulars;
            transaction.TransactionCodeType = entry.TranType;
            transaction.OurAccount = entry.ThisPartyAccount; //TODO: String formatting
            transaction.TheirAccount = entry.OtherPartyAccount;
            transaction.BatchNumber = entry.BatchNumber;
            transaction.OriginatingBank = entry.OriginatingBank;
            transaction.ProcessedDate = DateTime.Parse(entry.ProcessedDate);

            return transaction;
        }

        public IEnumerable<Transaction> LoadTransactionHistory()
        {
            List<Transaction> transactions = null;
            String currentDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            String fullFilePath = currentDirectory + "..\\..\\" + _transactionFileName;

            using (TextReader reader = File.OpenText(fullFilePath))
            {
                transactions = new List<Transaction>();
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    TransactionEntry transactionEntry = csv.GetRecord<TransactionEntry>();
                    Transaction transaction = ConvertToTransaction(transactionEntry);
                    transactions.Add(transaction);
                }
            }

            return transactions;
        }
    }
}
