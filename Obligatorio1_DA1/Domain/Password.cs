using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Domain
{
    public class Password
    {
        public string Category { get; set; }
        public string Site { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Notes { get; set; }

        public static string generate(int length, Boolean upercase, Boolean lowercase, Boolean digits, Boolean specialDigits)
        {
            return "hola";
        }
    }


}
