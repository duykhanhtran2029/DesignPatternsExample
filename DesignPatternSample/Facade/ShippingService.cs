using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Facade
{
    //Dịch vụ vận chuyển (ShippingService) : có thể chọn Free Shipping, Standard Shipping, Express Shipping.
    class ShippingService
    {
        public void freeShipping()
        {
           Console.WriteLine("Free Shipping");
        }

        public void standardShipping()
        {
           Console.WriteLine("Standard Shipping");
        }

        public void expressShipping()
        {
           Console.WriteLine("Express Shipping");
        }
    }
}
