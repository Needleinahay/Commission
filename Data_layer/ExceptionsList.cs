﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class NullEntryFromDb : Exception
    {
        public NullEntryFromDb() {}
        public NullEntryFromDb(string toBeMessage)
            : base(toBeMessage) {}
    }
}
