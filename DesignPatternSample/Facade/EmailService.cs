using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Facade
{
    //Dịch vụ email (EmailService) : có thể gửi mail cho khách hàng về tình hình đặt hàng, thanh toán, vận chuyển, nhận hàng.
    class EmailService
    {
        public void sendMail(String mailTo)
        {
            Console.WriteLine("Sending an email to " + mailTo);
        }
    }
}
