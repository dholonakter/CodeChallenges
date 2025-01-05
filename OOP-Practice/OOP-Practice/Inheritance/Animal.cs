using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance;

public class Animal
{
	protected string? Name { get; set; }

	public void PrintName()
	{
		Console.WriteLine("Animal name" + Name);
	}

}
