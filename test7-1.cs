using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7
{
    class QueryVMethodSyntax
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 8, 3, 6, 12 };
            //Query syntax:
            IEnumerable<int> numQuery1 =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;
            foreach (int i in numQuery1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(System.Environment.NewLine);
            Console.ReadLine();
        }
    }
}
