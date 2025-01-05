using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance;

public class Dog : Animal
{
	public Dog(string name)
	{
		Name = name;
	}

	public void Bark()
	{
		base.PrintName();
		Console.WriteLine("Name of Dog" + Name + "Woof");
	}
}
