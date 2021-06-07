using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replicator.Data.Models
{
    public class ReceiverProperty
    {
        public ECode Code { get; set; }
        public int ReceiverValue{ get; set; }

        public ReceiverProperty()
        {

        }

        public ReceiverProperty(ECode code, int receiverValue)
        {
            Code = code;
            ReceiverValue = receiverValue;
        }
    }
}
