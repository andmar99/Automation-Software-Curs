using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public class Cat : Animal, ISkills, IAnimalPlay
    {
        Animal cat = new Animal();
        public void AboutCat()
        {
            Console.WriteLine("About cat: ");
            SetAnimalColor("white");
            SetAnimalAge(2);
            Eat("fish");
        }
        public void AnimalRun()
        {
            Console.WriteLine("Animal skill: RUN");
        }
        public void AnimalPlay()
        {
            Console.WriteLine("The cat is playing.");
        }

        public void AnimalRun(int speed)
        {
            throw new NotImplementedException();
        }

        public void AnimalRun(string name, int speed)
        {
            throw new NotImplementedException();
        }
    }
}
