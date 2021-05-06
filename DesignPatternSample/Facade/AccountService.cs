using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Facade
{
    //Thông tin về tài khoản (AccountService) : lấy thông tin cơ bản của khách hàng thông qua email được cung cấp.
    class AccountService
    {
        public void getAccount(String email)
        {
            Console.WriteLine("Getting the account of " + email);
        }
    }
}
