using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentParser
{
    public class TransactionEntry
    {
        public String Date { get; set; }
        public String Amount { get; set; }
        public String Payee { get; set; }
        public String Particulars { get; set; }
        public String Code { get; set; }
        public String Reference { get; set; }
        public String TranType { get; set; }
        public String ThisPartyAccount { get; set; }
        public String OtherPartyAccount { get; set; }
        public String Serial { get; set; }
        public String TransactionCode { get; set; }
        public String BatchNumber { get; set; }
        public String OriginatingBank { get; set; }
        public String ProcessedDate { get; set; }
    }
}
