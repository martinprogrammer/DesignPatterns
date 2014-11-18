using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RoyalMail : IShippingCourier
    {
        public string GenerateConsignmentLabelFor(Address address)
        {
            return "RM-xxxx-xxx";
        }
    }
}
