using NUnit.Framework;
using Replicator.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace GlobalDataTest.ModelsTest
{
    [TestFixture]
    public class CollectionDescriptionTest
    {
        private static readonly object[] _source =
        {
            new object[] { 0, 0, new HistoricalCollection { } },
            new object[] { int.MinValue, int.MaxValue, new HistoricalCollection { ReceiverPropertyArray = new List<ReceiverProperty> { new ReceiverProperty(ECode.CODE_ANALOG, 0) } } },
            new object[] { int.MaxValue, int.MinValue, new HistoricalCollection { ReceiverPropertyArray = new List<ReceiverProperty> { new ReceiverProperty(ECode.CODE_SINGLENODE, int.MinValue), new ReceiverProperty(ECode.CODE_MULTIPLENODE, int.MaxValue) } } }
        };

        [Test]
        public void CollectionDescription_EmptyConstructor_ReturnsDefaults()
        {
            var result = new CollectionDescription();

            var hcollection = new HistoricalCollection();
            bool equal = !hcollection.ReceiverPropertyArray.Except(result.Collection.ReceiverPropertyArray).Any();

            Assert.IsTrue(result.ID == 0 && result.DataSet == 0 && equal);
        }

        [Test]
        [TestCaseSource("_source")]
        public void CollectionDescription_ConstructorWithParameters_ReturnsGivenValues(int iD, int dataSet, HistoricalCollection collection)
        {
            var result = new CollectionDescription(iD, dataSet, collection);

            var hcollection = new HistoricalCollection();

            bool equal = !hcollection.ReceiverPropertyArray.Except(result.Collection.ReceiverPropertyArray).Any();

            Assert.IsTrue(result.ID == iD && result.DataSet == dataSet && equal);
        }

        [Test]
        public void Collection_Description_ToString_Test()
        {
            var list = new List<ReceiverProperty>
            {
                new ReceiverProperty(ECode.CODE_ANALOG, 0),
                new ReceiverProperty(ECode.CODE_DIGITAL, 7)
            };

            var result = new CollectionDescription(1, 2, new HistoricalCollection(list));
            
            Assert.IsTrue(result.ToString() == "[DATASET:2]:CODE_ANALOG_0 CODE_DIGITAL_7 ");
        }

    }
}
