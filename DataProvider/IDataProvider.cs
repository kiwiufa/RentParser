using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentParser.DataProvider
{
    interface IDataProvider<T>
    {
        Task<IEnumerable<T>> LoadElementsAsync();
        Task SaveElementsAsync(IEnumerable<T> elements);
    }
}
