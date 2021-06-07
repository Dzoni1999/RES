using Replicator.Data.Models;
using ReplicatorDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.Interfaces
{
    public interface IReader
    {
        bool CheckDeadBand(int datasetID, CollectionDescription cd, ReplicatorDbContext _context);
        void StoreInDataBase(int datasetID, CollectionDescription cd, ReplicatorDbContext _context);
        string ReadDataFromDataBase(ECode c, int datasetID, ReplicatorDbContext _context, string dateFrom, string dateTo);
    }
}
