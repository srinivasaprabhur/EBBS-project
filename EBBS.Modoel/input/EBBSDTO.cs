using EBBS.Modoel.output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBBS.Modoel.input
{
    public class EBBSDTO
    {
        public int id { get; set; }
        public string? ServiceType { get; set; }
        public long? serviceNumber { get; set; }
        public int? consumedUnit { get; set; }
        public int? fromUnit { get; set; }
        public int? toUnit { get; set; }
        public int? pricePerUint { get; set; }
        public object? userDetailList { get; set; }

        public static implicit operator EBBSDTO(EBBSResult v)
        {
            throw new NotImplementedException();
        }
    }
}
