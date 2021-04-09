﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns_Factories_Iterators
{
    // controls access to a TextFile object
    public class FileController
    {
        private Mode status;       // the current mode of use of the file
        private TextFile thefile;  // the data structure controlled
        private int count;

        public FileController(TextFile f)
        {
            thefile = f;
            status = Mode.Available;
        }

        // opens file for read use. 
        // returns handle to FileReader object (returns null if cannot construct)
        public FileReader openRead()
        {
            lock (this)
            {
                FileReader ans = null;
                if (status == Mode.Available || status == Mode.Read)
                {
                    status = Mode.Read;
                    ans = thefile.makeReader(this.closeRead);
                    count++;
                }
                return ans;
            }
        }

        // closes file and resets mode to Mode.Available if no more readers
        private void closeRead()
        {
            lock (this)
            {
                if (count > 1)
                {
                    count--;
                }
                else if (count == 1)
                {
                    status = Mode.Available;
                    count = 0;
                }
                
            }
        }

        // opens file for write use; returns handle to FileWriter (returns null if not allocated)
        public FileWriter openWrite()
        {
            lock (this)
            {
                FileWriter ans = null;
                if (status == Mode.Available)
                {
                    status = Mode.Write;
                    ans = thefile.makeWriter(closeWrite);
                }
                return ans;
            }
        }

        // closes file and resets mode to Mode.Available
        private void closeWrite()
        {
            lock (this)
            {
                status = Mode.Available;
            }
        }
    }
}
