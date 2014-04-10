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

        public string Company { get; set; }


        public Car(string color, int speed)
        {
            Color = color;
            Speed = speed;
        }


        public void stop()
        {
            Speed = 0;
            Console.WriteLine("Stopped driving.");
        }
    }
}
