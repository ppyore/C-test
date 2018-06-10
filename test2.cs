using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class test2
    {
        public class myGeneric<T>
        {
            public void myTest(T myValue)
            {
                System.Type myType = myValue.GetType();
                Console.WriteLine(myType);
            }
        }
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
            Console.ReadLine();
        }
    }
}
