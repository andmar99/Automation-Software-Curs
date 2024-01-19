using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public class Dog : Animal, ISkills, IAnimalPlay
    {
        Animal dog = new Animal();
        public void AboutDog()
        {
            Console.WriteLine("About dog: ");
            SetAnimalColor("black");
            SetAnimalAge(1);
            Eat("dentastix");
        }
        public void AnimalPlay()
        {
            Console.WriteLine("The dog is playing.");
        }
        //Override
        public void AnimalRun()
        {
            Console.WriteLine("Animal skill: RUN");
        }

        public void AnimalRun(int speed)
        {
            Console.WriteLine("Animal speed: " + speed);
        }

        public void AnimalRun(string name, int speed)
        {
            Console.WriteLine("Animal name is: " + name + "and animal speed is " + speed);
        }

        private string dogName;
        public string Name
        {
            get
            {
                return dogName;
            }
            set
            {
                dogName = value;
            }
        }
    }
}
