﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class TapeContext
    {
        public TapeState currTape;

        public TapeContext()
        {
            currTape = TapeState._tapeIn;
        }
    }
}
