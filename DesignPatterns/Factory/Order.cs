using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Order
    {
        public int CourierTrackingId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal WeightInKg { get; set; }
        public Address DispatchAddress { get; set; }
    }
}
