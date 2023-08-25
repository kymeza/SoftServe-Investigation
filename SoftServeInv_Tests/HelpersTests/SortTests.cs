using SoftServe_Inv.Helpers;
using SoftServeInv_Tests.Setups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeInv_Tests.HelpersTests
{
    public class SortTests : IClassFixture<DataSetup>
    {
        private readonly IEnumerable<dynamic> _sampleData;

        public SortTests(DataSetup setup)
        {
            _sampleData = setup.SampleData;
        }

        [Fact]
        public void SortByName_Ascending_ReturnsSortedCollection()
        {
            var sorted = Sort.SortByName(_sampleData, "asc").ToList();

            for (int i = 0; i < sorted.Count - 1; i++)
            {
                Assert.True(string.Compare(sorted[i].name.common.ToString(), sorted[i + 1].name.common.ToString(), StringComparison.OrdinalIgnoreCase) <= 0);
            }
        }

        [Fact]
        public void SortByName_Descending_ReturnsSortedCollection()
        {
            var sorted = Sort.SortByName(_sampleData, "desc").ToList();

            for (int i = 0; i < sorted.Count - 1; i++)
            {
                Assert.True(string.Compare(sorted[i].name.common.ToString(), sorted[i + 1].name.common.ToString(), StringComparison.OrdinalIgnoreCase) >= 0);
            }
        }

        [Fact]
        public void SortByName_InvalidSort_ReturnsErrorObject()
        {
            var result = Sort.SortByName(_sampleData, "invalidSort").ToList();

            Assert.Single(result);
            Assert.Equal("{ error = Invalid Sort }", result[0].ToString());
        }
    }
}
