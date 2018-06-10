using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class test3
    {    public class myGeneric<T>
        {
            //泛型方發宣告
            public void myTest(T myValue)
            {
                System.Type myType = myValue.GetType();
                Console.WriteLine(myType);
            }
        }
        static void Main(string[] args)
        {
            List<string> myGen = new List<string>();
            myGen.Add("Amy");
            myGen.Add("Barry");
            myGen.Add("Allen");
            myGen.Add("Clark");
            myGen.Add("Bill");

            foreach (string i in myGen)
            {
             Console.WriteLine(i);            
            }
             Console.ReadLine();
        }        
    }
}

