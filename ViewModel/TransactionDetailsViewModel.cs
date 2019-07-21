using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentParser.ViewModel
{
    public class TransactionDetailsViewModel
    {
        public TransactionEntry TransactionEntry { get; set; }

        public TransactionDetailsViewModel(TransactionEntry transactionEntry)
        {
            TransactionEntry = transactionEntry;
        }
    }
}
