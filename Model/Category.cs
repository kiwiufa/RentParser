using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentParser.Model
{
    public class Category
    {
        private String _key { get; set; }
        public String Name { get; set; }
        public ObservableCollection<String> AssociatedValues { get; set; }
    }
}
