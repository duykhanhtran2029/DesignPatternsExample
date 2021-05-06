using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Facade
{
    //Dịch vụ tin nhắn (SMS) : có thể gửi thông báo SMS cho khách hàng khi thanh toán online.
    class SMSService
    {
        public void sendSMS(String mobilePhone)
        {
            Console.WriteLine("Sending an mesage to " + mobilePhone);
        }
    }
}
