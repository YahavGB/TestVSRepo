using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Red", 25);

            Console.WriteLine("Hello, World!");
            Console.WriteLine("The speed is {0}", c.Speed);
        }
    }
}
