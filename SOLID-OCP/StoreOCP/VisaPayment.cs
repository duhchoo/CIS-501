using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOCP
{
    class VisaPayment : IPaymentMethod
    {
        public bool ProcessPayment(double amount)
        {
            Console.WriteLine("Visa");
            return true;
        }

    }
}
