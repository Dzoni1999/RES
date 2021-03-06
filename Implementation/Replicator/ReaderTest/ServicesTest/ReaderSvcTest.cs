using Replicator.Data.Models;
using Moq;
using NUnit.Framework;
using ReplicatorDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderTest.ServicesTest
{
    [TestFixture]
    public class ReaderSvcTest
    {
        [Test]
        public void ReadDataFromDataBase()
        {
            try
            {
                ReplicatorDbContext _context = new ReplicatorDbContext();

                string dateFrom = "2020-06-13 16:58:02.347";
                string dateTo = "2020-06-13 16:58:02.677";
                Reader.Reader reader = new Reader.Reader(1);

                ECode c = ECode.CODE_ANALOG;
                int datasetID = 1;
                reader.service.ReadDataFromDataBase(c, datasetID, _context, dateFrom, dateTo);

                c = ECode.CODE_DIGITAL;
                reader.service.ReadDataFromDataBase(c, datasetID, _context, dateFrom, dateTo);

                c = ECode.CODE_CUSTOM;
                datasetID = 2;
                reader.service.ReadDataFromDataBase(c, datasetID, _context, dateFrom, dateTo);

                c = ECode.CODE_LIMITSET;
                reader.service.ReadDataFromDataBase(c, datasetID, _context, dateFrom, dateTo);

                c = ECode.CODE_SINGLENODE;
                datasetID = 3;
                reader.service.ReadDataFromDataBase(c, datasetID, _context, dateFrom, dateTo);

                c = ECode.CODE_MULTIPLENODE;
                reader.service.ReadDataFromDataBase(c, datasetID, _context, dateFrom, dateTo);

                c = ECode.CODE_CONSUMER;
                datasetID = 4;
                reader.service.ReadDataFromDataBase(c, datasetID, _context, dateFrom, dateTo);

                c = ECode.CODE_SOURCE;
                reader.service.ReadDataFromDataBase(c, datasetID, _context, dateFrom, dateTo);

            }
            catch (Exception)
            {
                Assert.Fail();
            }
            Assert.Pass();
            



        }

    }
}
