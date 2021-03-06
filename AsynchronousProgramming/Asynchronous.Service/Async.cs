﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous.Service
{
    public class AsyncMethod
    {
        public async Task DoSomethingAsync()
        {
            int val = 13;
            await Task.Delay(TimeSpan.FromSeconds(1));
            val *= 2;
            await Task.Delay(TimeSpan.FromSeconds(1));
            Trace.WriteLine(val);
        }
    }
}
