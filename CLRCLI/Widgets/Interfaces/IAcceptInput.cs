﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRCLI.Widgets
{
    interface IAcceptInput
    {
        bool Keypress(ConsoleKeyInfo key);
    }
}
