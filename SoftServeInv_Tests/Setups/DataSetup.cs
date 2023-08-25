using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeInv_Tests.Setups
{
    public class DataSetup
    {
        public IEnumerable<dynamic> SampleData { get; private set; }

        public DataSetup()
        {
            var json = File.ReadAllText("TestData/SampleRESTCountriesData.json");
            var deserializedData = JsonConvert.DeserializeObject<IEnumerable<dynamic>>(json);
            SampleData = deserializedData ?? throw new InvalidDataException();
        }

    }
}
