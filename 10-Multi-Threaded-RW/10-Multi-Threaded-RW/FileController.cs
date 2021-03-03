﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multi_Threaded_RW
{
    // a controller for a sequential text file:
    // allows a thread to read or write the file
    public class FileController
    {
        private File thefile;  // the file controlled by this controller

        Status state;
        // I.  DECLARE AND USE A STATE VARIABLE THAT REMEMBERS STATE OF thefile's USE
        // II. ADD CODE TO PREVENT TWO THREADS FROM OPENING THE FILE AT THE SAME INSTANT.

        public FileController(File f) { thefile = f; }

        // opens the file for read use; returns handle to file.  
        // If file cannot be opened, returns null.
        public Reader openRead()
        {
            Reader r = null;
            if (state == Status.Closed)
            {
                thefile.initRead();
                r = thefile;
                lock (this)
                {
                    state = Status.Reading;
                }
            }
            return r;
        }

        // opens the file for write use; returns handle to file.  
        //   If file cannot be opened, returns null.
        public Writer openWrite()
        {
            Writer w = thefile;
            if (state == Status.Closed)
            {
                thefile.initWrite();
                w = thefile;
                lock (this)
                {
                    state = Status.Writing;
                }
            }
            return w;

        }

        // closes file
        public void close()
        {
            state = Status.Closed;
        }
    }
}
