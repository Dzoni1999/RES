using NUnit.Framework;
using System;
using Writer.Services;

namespace WriterTest.ServicesTest
{
    [TestFixture]
    public class WriterSvcTest 
    {
        //Metoda koja je pravila problem sa static modifikatorom
        [Test]
        public void GenerateRandomValueTest_WithNoParameters_ChecksValidValue()
        {
            try
            {
                WriterSvc writerSvc = new WriterSvc();
                for (int i = 0; i < 10000; i++)
                {
                    writerSvc.GenerateRandomValue();
                }
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }

        [Test]
        public void StartSendingDataTest()
        {
            try
            {
                WriterSvc writerSvc = new WriterSvc();
                ReplicatorSender.ReplicatorSender sender = new ReplicatorSender.ReplicatorSender();
                writerSvc.StartSendingData(sender);
                writerSvc.StopSendingData();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            Assert.Pass();
        }
    }
}
