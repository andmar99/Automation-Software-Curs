using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public interface ISkills
    {
        void AnimalRun();
        //Overloading
        void AnimalRun(int speed);
        void AnimalRun(string name, int speed);

    }
}
