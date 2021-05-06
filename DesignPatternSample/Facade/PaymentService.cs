using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Facade
{
    /*Dịch vụ thanh toán (PaymentService) : có thể thanh toán thông qua Paypal, thẻ tín dụng (Credit Card), 
                                             tài khoản ngân hàng trực tuyến (E-banking), Tiền mặt (cash).*/
    class PaymentService
    {
        public void paymentByPaypal()
        {
            Console.WriteLine("Payment by Paypal");
        }

        public void paymentByCreditCard()
        {
            Console.WriteLine("Payment by Credit Card");
        }

        public void paymentByEbankingAccount()
        {
            Console.WriteLine("Payment by E-banking account");
        }

        public void paymentByCash()
        {
            Console.WriteLine("Payment by cash");
        }
    }
}
