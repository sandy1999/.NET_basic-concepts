using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    class Delegate
    {
        public static string addString(string str)
        {
            return "Hello " + str;
        }
    }

    delegate void addDelegate(int x, int y);
    delegate string addStrint(string str);
}
