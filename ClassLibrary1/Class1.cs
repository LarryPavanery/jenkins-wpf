using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calc
    {
        public int MyPropertyInt { get; set; }
        public string MyPropertyString { get; set; }

        public int soma(int x, int y)
        {
            return x + y;
        }
    }
}
