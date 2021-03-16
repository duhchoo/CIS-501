using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOCP
{
    class CashPayment : IPaymentMethod
    {
        public bool ProcessPayment(double amount)
        {
            Console.WriteLine("Cash");
            return true;
        }

        public static bool ProcessPaymentD(double amount)
        {
            Console.WriteLine("Cash Delegate");
            return true;
        }
    }
}
