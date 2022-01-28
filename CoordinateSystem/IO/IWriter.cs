﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateSystem.IO
{
    public interface IWriter
    {
        void WriteLine(string message);

        void Write(string message);
    }
}
