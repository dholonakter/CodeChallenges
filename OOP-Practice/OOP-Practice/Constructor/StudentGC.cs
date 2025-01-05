using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Constructor;

public class StudentGC
{
	public string Name { get; set; }
	public int Age { get; set; }
	public StudentGC()
	{
		Console.WriteLine("Student created");
	}
	~StudentGC()
	{
		Console.WriteLine("Student destroyed");
	}
	public void Dispose()
	{
		Console.WriteLine("Student destroyed");
	}
}
