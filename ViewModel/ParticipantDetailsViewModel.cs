using RentParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentParser.ViewModel
{
    public class ParticipantDetailsViewModel
    {
        private static Participant GenerateParticipantFromTransaction(Transaction transaction)
        {
            Participant participant = new Participant();
            participant.Accounts.Add(transaction.Amount > 0 ? transaction.TheirAccount : transaction.OurAccount);
            participant.Name = transaction.PayeeLabel;
            participant.Commentary = transaction.Reference;

            return participant;
        }

        public Participant Participant { get; set; }

        public ParticipantDetailsViewModel(Transaction transaction)
        {
            if(transaction.Payee != null)
            {
                Participant = transaction.Payee; //TODO: Handle us vs them
            }
            else 
            {
                Participant = GenerateParticipantFromTransaction(transaction);
            }
        }
    }
}
