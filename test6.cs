using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test6
{
    public class myBilly<T>
    {
        public virtual void Y()
        {
            Console.WriteLine("myBilly.Y");
            Console.ReadLine();
        }
    }    
   class B:myBilly<string>
    {
        public override void Y()
        {
            Console.WriteLine("B.Y");
            Console.ReadLine();
        }
    }
    class C:myBilly<string>
    {
        public override void Y()
        {
            Console.WriteLine("C.Y");
            Console.ReadLine();
        }
    }
    class test6
    {   
        static void Main(string[] args)
        {   ShowString();
            ShowString("Category");
            myBilly<string> ab = new B();
            ab.Y();
            myBilly<string> ac = new C();
            ac.Y();
        }
        private static void ShowString(string v)
        {
            Console.WriteLine(v);
        }
        private static void ShowString()
        {
            ShowString("Popular");
        }
    }
}
