﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public interface IHash
    {
        string Hash(string textToHash, string salt);
    }
}
