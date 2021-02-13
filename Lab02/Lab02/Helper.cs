using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lab02
{
    public class Helper
    {
        private Manager myManager;

        public Helper(Manager m)
        {
            myManager = m;
        }

        public void DoWork()
        {
            Console.WriteLine("HELPER: Working...");
        }

        public void Finished()
        {
            Console.WriteLine("HELPER: Done.");

            myManager.Remove(this);
        }




    }
}
