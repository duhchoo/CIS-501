using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOCP
{
    public interface IPaymentMethod
    {
        bool ProcessPayment(double amount);

    }
}
