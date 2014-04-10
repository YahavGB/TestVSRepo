using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car
    {
        public string Color { get; set; }

        public int Speed { get; set; }

        public void drive()
        {
            Console.WriteLine("I'm driving at {0}km/h!", this.Speed);
        }
    }
}
