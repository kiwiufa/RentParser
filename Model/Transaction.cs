using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentParser.Model
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public Participant Payee { get; set; }
        public String PayeeLabel { get; set; }
        public String Particulars { get; set; }
        public String Reference { get; set; }
        public String TransactionCodeType { get; set; }
        public String OurAccount { get; set; } //TODO add extra handling? or utility function
        public String TheirAccount { get; set; }
        public String Serial { get; set; }
        public String TransactionCode { get; set; }
        public String BatchNumber { get; set; }
        public String OriginatingBank { get; set; }
        public DateTime ProcessedDate { get; set; }
    }
}
