using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replicator.Data.Models
{
    public enum LogComponent
    {
        WRITER,
        REPLICATOR_SENDER,
        REPLICATOR_RECEIVER,
        READER,
        DATABASE
    }
}
