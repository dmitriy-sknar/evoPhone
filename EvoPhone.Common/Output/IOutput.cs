﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoPhone.Common {
    public interface IOutput {
        void Write(string text);
        void WriteLine(string text);
    }
}