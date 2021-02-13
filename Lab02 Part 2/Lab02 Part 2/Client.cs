using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lab02
{
    public class Client
    {
        Manager manager;

        public Client(Manager m)
        {
            manager = m;
        }

        public void Work()
        {
            Console.WriteLine("CLIENT: Requesting help to Manager.");

            Helper helper = manager.RequestHelp();
            
            helper.DoWork();

            helper.Finished();

        }
    }
}
