using RentParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentParser.ViewModel
{
    public class TransactionDetailsViewModel
    {
        public Transaction Transaction { get; set; }

        public TransactionDetailsViewModel(Transaction transactionEntry)
        {
            Transaction = transactionEntry;
        }
    }
}
