using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public abstract class Wings
    {
        public void WingsColor()
        {
            Console.WriteLine("Insert wings color: ");
            var wingsColor = Console.ReadLine();
            Console.WriteLine("Wings color: " + wingsColor);
        }
        public abstract void AnimalFly();
        public abstract void WingsSize(double size);
    }
}
