using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance.Animals
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Cat Mews");
        }
    }
}
