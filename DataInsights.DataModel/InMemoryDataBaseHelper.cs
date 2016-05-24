using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class InMemoryDataBaseHelper
    {
        private static readonly List<RawDataEntry> inMemoryDb = new List<RawDataEntry>();
        public static void Save(RawDataEntry entry)
        {
            inMemoryDb.Add(entry);
        }
    }
}
