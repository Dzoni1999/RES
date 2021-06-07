using NUnit.Framework;
using Replicator.Data.Models;

namespace GlobalDataTest.ModelsTest
{
    [TestFixture]
    public class ReceiverPropertyTest
    {
        [Test]
        //[TestCase()]
        public void ReceiverProperty_EmptyConstructor_ReturnsDefaults()
        {
            var result = new ReceiverProperty();

            Assert.AreEqual(result.Code, ECode.CODE_ANALOG);
            Assert.AreEqual(result.ReceiverValue, 0);
        }

        [Test]
        [TestCase(ECode.CODE_ANALOG, 0)]
        [TestCase(ECode.CODE_SOURCE, -20)]
        [TestCase(ECode.CODE_ANALOG, null)]
        [TestCase(null, 0)]
        [TestCase(ECode.CODE_DIGITAL, int.MinValue)]
        [TestCase(ECode.CODE_DIGITAL, int.MaxValue)]
        public void ReceiverProperty_ConstructorWithParameters_ReturnsGivenValues(ECode code, int receiverValue)
        {
            var result = new ReceiverProperty(code, receiverValue);

            Assert.AreEqual(result.Code, code);
            Assert.AreEqual(result.ReceiverValue, receiverValue);
        }
    }
}
