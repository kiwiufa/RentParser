using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentParser.DataProvider
{
    public class DataProvider<T> : IDataProvider<T>
    {
        private string _sourceFileName;

        public DataProvider(String fileName)
        {
            _sourceFileName = fileName;
        }

        public Task<IEnumerable<T>> LoadElementsAsync()
        {
            IEnumerable<T> elementList;
            if (File.Exists(_sourceFileName))
            {
                var json = File.ReadAllText(_sourceFileName);
                elementList = JsonConvert.DeserializeObject<List<T>>(json);
            }
            else
            {
                elementList = new List<T>();
            }

            return Task.FromResult(elementList);
        }

        public Task SaveElementsAsync(IEnumerable<T> elements)
        {
            var json = JsonConvert.SerializeObject(elements, Formatting.Indented);
            File.WriteAllText(_sourceFileName, json);
            return Task.CompletedTask;
        }
    }
}
