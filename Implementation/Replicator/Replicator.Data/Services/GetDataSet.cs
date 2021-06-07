using Replicator.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replicator.Data.Services
{
    public class GetDataSet
    {
        public static int GetDatasetForCode(ECode code1, ECode code2)
        {
            if (code1 == ECode.CODE_ANALOG && code2 == ECode.CODE_DIGITAL)
                return 1;
            else if (code1 == ECode.CODE_CUSTOM && code2 == ECode.CODE_LIMITSET)
                return 2;
            else if (code1 == ECode.CODE_SINGLENODE && code2 == ECode.CODE_MULTIPLENODE)
                return 3;
            else if (code1 == ECode.CODE_CONSUMER && code2 == ECode.CODE_SOURCE)
                return 4;
            else
                return 0;
        }
    }
}
