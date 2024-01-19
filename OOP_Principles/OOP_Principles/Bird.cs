using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public class Bird : Wings
    {
        public void AboutWingsColor()
        {
            WingsColor();
        }
        public override void AnimalFly()
        {
            Console.WriteLine("Type YES if this animal is flying and NO if not.");
            var answer = Console.ReadLine();
            if(answer.Equals("YES"))
            {
                Console.WriteLine("This bird can fly.");
            }
            else if (answer.Equals("NO"))
            {
                Console.WriteLine("This animal don't fly.");
            }
            else
            {
                Console.WriteLine("Invalid answer");
            }
        }

        public override void WingsSize(double size)
        {
            Console.WriteLine("Wings size: " + size);
        }
    }
}
