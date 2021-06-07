using NUnit.Framework;
using Replicator.Data.Models;
using Replicator.Data.Services;

namespace GlobalDataTest.ServicesTest
{
    [TestFixture]
    public class GetDataSetTest
    {
        [Test]
        [TestCase(ECode.CODE_ANALOG, ECode.CODE_DIGITAL)]
        [TestCase(ECode.CODE_SINGLENODE, ECode.CODE_MULTIPLENODE)]
        [TestCase(ECode.CODE_CONSUMER, ECode.CODE_SOURCE)]
        [TestCase(ECode.CODE_CUSTOM, ECode.CODE_LIMITSET)]
        public void GetDataSetTest_GivenValidCodes_ReturnsDataSetForValidGivenCodes(ECode code1, ECode code2)
        {
            var result = GetDataSet.GetDatasetForCode(code1, code2);

            Assert.IsTrue(result != 0);
        }

        [Test]
        [TestCase(ECode.CODE_ANALOG, ECode.CODE_ANALOG)]
        [TestCase(ECode.CODE_LIMITSET, ECode.CODE_DIGITAL)]
        public void GetDataSetTest_GivenInValidCodes_ReturnsDataSetForInValidGivenCodes(ECode code1, ECode code2)
        {
            var result = GetDataSet.GetDatasetForCode(code1, code2);

            Assert.IsTrue(result == 0);
        }
    }
}
