using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lab02
{
    public class Helper
    {
        private Manager myManager = new Manager();

        public delegate void RemoveMethod(Helper helper);

        RemoveMethod handler = null;

        public Helper(Manager m)
        {
            myManager = m;
            handler = myManager.Remove;
        }

        public void DoWork()
        {
            Console.WriteLine("HELPER: Working...");
        }

        public void Finished()
        {
            Console.WriteLine("HELPER: Done.");

            handler(this);
        }




    }
}
