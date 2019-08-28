using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug_27_work
{
    class ArrayListInteger
    {
        static void Main(string[] args)
        {
            ArrayList integer = new ArrayList();

            integer.Add(2);
            integer.Add(4);
            integer.Add(6);
            integer.Add(8);
            integer.Add(10);

            foreach (int g in integer)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("Total number of Items = " + integer.Count);
            Console.WriteLine("Index of 10 = " + integer.IndexOf(10));

            Console.Read();
        }
    }
}
//Perfect