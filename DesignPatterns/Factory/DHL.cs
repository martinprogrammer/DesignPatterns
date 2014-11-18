using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    class DHL : IShippingCourier
    {
        public string GenerateConsignmentLabelFor(Address address)
        {
            return "DHL-XXX-XXX-XXX";
        }
    }
}
