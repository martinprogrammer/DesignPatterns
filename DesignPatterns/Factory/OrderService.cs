using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class OrderService
    {
        public void Dispatch(Order order)
        {
            IShippingCourier myCourier = UKShippingCourierFactory.CreateShipper(order);
            myCourier.GenerateConsignmentLabelFor(order.DispatchAddress);
        }
      
    }
}
