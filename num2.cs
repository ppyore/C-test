using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    class num2
    {
        static void Main(string[] args)
        {
            int? i = 10;
            if (i != null)
            {
                Console.WriteLine(i.Value);
            }
            else
            {
               Console.WriteLine("Undefined");
            }
        }
    }
}
