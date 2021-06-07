using NUnit.Framework;
using Replicator.Data.Models;
using System.Collections.Generic;

namespace GlobalDataTest.ModelsTest
{
    [TestFixture]
    public class HistoricalCollectionTest
    {
        private static readonly object[] _sourceLists =
        {
            new object[] {new List<ReceiverProperty> {new ReceiverProperty(ECode.CODE_ANALOG, 0)}},   //case 1
            new object[] {new List<ReceiverProperty> { new ReceiverProperty(ECode.CODE_SINGLENODE, int.MinValue), new ReceiverProperty(ECode.CODE_MULTIPLENODE, int.MaxValue) } } //case 2
        };

        [Test]
        public void HistoricalCollection_EmptyConstructor_ReturnsDefaults()
        {
            var result = new HistoricalCollection();

            Assert.AreEqual(result.ReceiverPropertyArray, new List<ReceiverProperty>());
        }

        [Test]
        [TestCase(null)]
        [TestCaseSource("_sourceLists")]
        public void HistoricalCollection_ConstructorWithParameters_ReturnsGivenValues(List<ReceiverProperty> receiverPropertyArray)
        {
            var result = new HistoricalCollection(receiverPropertyArray);

            Assert.AreEqual(result.ReceiverPropertyArray, receiverPropertyArray);
        }

    }
}
