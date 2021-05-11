using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Utilities
{
    public struct PasswordGenerationOptions
    {
        public int Length { get; set; }
        public bool Uppercase { get; set; }
        public bool Lowercase { get; set; }
        public bool Digits { get; set; }
        public bool SpecialDigits { get; set; }
    }
}
