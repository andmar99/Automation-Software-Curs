using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public class Animal
    {
        public void Eat(string foodType)
        {
            Console.WriteLine("This animal eat: " + foodType);
        }
        public void SetAnimalColor(string animalColor)
        {
            Console.WriteLine("This animal color is: " + animalColor);
        }
        public void SetAnimalAge(int age)
        {
            Console.WriteLine("Animal age is: " + age);
        }
    }
}
