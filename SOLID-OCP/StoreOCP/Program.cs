using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreOCP
{

    public delegate bool PaymentMethod(double amount);



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Console.WriteLine("*** N A I V E ***");
            Console.WriteLine();
            Console.WriteLine("  Select Method of Payment");
            Console.WriteLine("  1- Cash");
            Console.WriteLine("  2- Credit Card");
            int op = Convert.ToInt32(Console.ReadLine());

            OrderOCP orderOPC = new OrderOCP(1, "Headphones", 35.99);

            switch (op)
            {
                case 1:
                    orderOPC.ProcessOrder(CashPayment.ProcessPaymentD);
                    orderOPC.ProcessOrder(new CashPayment().ProcessPayment);
                    break;
                case 2:
                    orderOPC.ProcessOrder(new VisaPayment().ProcessPayment);
                    break;
                default:
                    Console.WriteLine("Payment Method Not Accepted");
                    break;
            }
            Console.ReadLine();

        }


    }
}
