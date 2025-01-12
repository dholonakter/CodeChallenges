using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance.Animals;

public class Dog : Animal
{
    public Dog(string name)
    {
        Name = name;
    }
    public Dog()
    {

    }
    public void Bark()
    {
        PrintName();
        Console.WriteLine("Name of Dog" + Name + "Woof");
    }
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Dog Barks");
    }
}
