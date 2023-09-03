using EBBS.Modoel.input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBBS.Modoel.output
{
    public class EBBSResult
    {
        public EBBSDTO? userDetail { get; set; }

        public List<EBBSDTO>? userDetailList { get; set; }
    }
}
