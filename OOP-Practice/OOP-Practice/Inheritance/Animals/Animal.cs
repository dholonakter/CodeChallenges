using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance.Animals;

public class Animal
{
    protected string? Name { get; set; }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }

    public void PrintName()
    {
        Console.WriteLine("Animal name" + Name);
    }

}
