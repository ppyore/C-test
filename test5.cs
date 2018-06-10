using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    public class myBilly<T>
    {
        T[] innerArray = new T[0];
        public void billy(T item)
        {
            Array.Resize(ref innerArray, innerArray.Length + 1);
            innerArray[innerArray.Length - 1] = item;
        }
        public T[] All()
        {
            return innerArray;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            myBilly<int> listA = new myBilly<int>();
            listA.billy(3);
            listA.billy(4);
            listA.billy(5);
            foreach (int row in listA.All())
            {
                Console.WriteLine(row);
            }
            Console.ReadLine();
        }
    }
}
