using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_BasicDelegate
{
    internal class Operatrion
    {
        public string Concat(string str1, string str2)
        { 
            return str1 + str2;
        }

        public string ChangeCase(string str1, string str)
        { 
            if(str == "U") return str1.ToUpper();
            if(str == "L") return str1.ToLower();
            return str1;
        }
    }
}
