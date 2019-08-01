using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentParser.Model
{
    public class Participant
    {
        public String Name { get; set; }
        public ObservableCollection<String> Accounts { get; set; }

        public String AssociatedProperty { get; set; }

        public String Commentary { get; set; }

        public Participant()
        {
            Accounts = new ObservableCollection<string>();
        }
    }
}
