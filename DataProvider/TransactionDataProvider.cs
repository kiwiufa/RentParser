using CsvHelper;
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
        private static readonly string _transactionFileName = "C:\\Repos\\RentParser\\Rental-3JUN2017-to-3JUN2019.csv";
        //ImportFilename = "C:\\Repos\\RentParser\\Rental-3JUN2017-to-3JUN2019.csv"
        public IEnumerable<TransactionEntry> LoadTransactionHistory()
        {
            List<TransactionEntry> transactions = null;

            using (TextReader reader = File.OpenText(_transactionFileName))
            {
                transactions = new List<TransactionEntry>();
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    TransactionEntry transaction = csv.GetRecord<TransactionEntry>();
                    transactions.Add(transaction);
                }
            }

            return transactions;
        }
    }
}
