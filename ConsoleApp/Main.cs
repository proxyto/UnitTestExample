using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new List<int>() { 1, 2, 3, 6, 4, 5, 3 };
            var e = l.GetEnumerator();
            while(e.MoveNext())
            {
                int value = e.Current;
                Console.WriteLine(value);
            }
           
        }
    }
}
