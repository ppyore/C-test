using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test7_2
{
    class myBilly
        {
       // 自動實作屬性.
       public string Name { get; set; }
       public int Age { get; set; }
    }
    class Billy
    {
            public void Run()
         {
             var empList = new List<myBilly>() 
             {
                 new myBilly { Name = "Michael", Age = 20 },
                  new myBilly{ Name = "Douglas", Age = 25 },
                  new myBilly{ Name = "Jenifer", Age = 14 }
            }; 
              Predicate<myBilly> p = e => e.Name.StartsWith("M"); // Lambda
              myBilly emp = empList.Find(p);
              Console.WriteLine(emp.Name);
        }
      }
    class Program
    {
        static void Main(string[] args)
        {
            Billy demo = new Billy();
            demo.Run();
            Console.ReadLine();
        }
    }
}
