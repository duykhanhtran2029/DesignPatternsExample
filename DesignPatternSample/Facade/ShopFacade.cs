using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Facade
{
    /*ShopFacade : là một Facade Pattern, class này bao gồm các dịch vụ có bên trong hệ thống. 
     * Nó cung cấp một vài phương thức để Client có thể dễ dàng mua hàng. 
     * Tùy vào nghiệp vụ mà nó sẽ sử dụng những dịch tương ứng, 
     * chẳng hạn dịch vụ SMS chỉ được sử dụng nếu khách hàng đăng ký mua hàng 
     * thông qua hình thức thanh toán online (Paypal, E-banking, …).
     */
    class ShopFacade
    {
        private static ShopFacade INSTANCE = new ShopFacade();

        private AccountService accountService;
        private PaymentService paymentService;
        private ShippingService shippingService;
        private EmailService emailService;
        private SMSService smsService;

        private ShopFacade()
        {
            accountService = new AccountService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();
            emailService = new EmailService();
            smsService = new SMSService();
        }

        public static ShopFacade getInstance()
        {
            return INSTANCE;
        }

        public void buyProductByCashWithFreeShipping(String email)
        {
            accountService.getAccount(email);
            paymentService.paymentByCash();
            shippingService.freeShipping();
            emailService.sendMail(email);
            Console.WriteLine("Done\n");
        }

        public void buyProductByPaypalWithStandardShipping(String email, String mobilePhone)
        {
            accountService.getAccount(email);
            paymentService.paymentByPaypal();
            shippingService.standardShipping();
            emailService.sendMail(email);
            smsService.sendSMS(mobilePhone);
            Console.WriteLine("Done\n");
        }
    }
}
