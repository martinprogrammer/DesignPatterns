using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class UKShippingCourierFactory
    {
        
        public static IShippingCourier CreateShipper(Order order)
        {
            if (order.TotalCost >50)
                return new RoyalMail();
            else
                return new DHL();

        }
    }
}
