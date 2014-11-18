using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class BasePrice : IPrice
    {
        private decimal _cost;
        decimal IPrice.Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }
    }
}
