using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    public class Manager
    {
        private List<Helper> Active = new List<Helper>();

        public void Remove(Helper helper)
        { 
            Active.Remove(helper);

            Console.WriteLine("MANAGER: Removing Helper from Active List.");
        }

        public Helper RequestHelp()
        {
            Console.WriteLine("MANAGER: Client requesting help.");

            Helper helper = new Helper(this);

            Console.WriteLine("MANAGER: Created Helper.");

            Active.Add(helper);

            Console.WriteLine("MANAGER: Adding Helper to Active List.");

            return helper;
        }
    }
}
