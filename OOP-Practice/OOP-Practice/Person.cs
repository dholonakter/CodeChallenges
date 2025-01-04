using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice;

public class Person
{
	private string _name;
	private int _age;

	public string? Name
	{
		get { return _name; }
		private set { _name = value; }

	}

	public int Age
	{
		get { return _age; }
		private set
		{
			if (value >= 0)
			{
				_age = value;
			}
			else
			{
				throw new ArgumentException("Age can not have negative value");
			}

		}


	}

	public Person()
	{
		Name = "Unknown";
		Age = 0;

	}
	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}

	public virtual void SayHello()
	{
		Console.WriteLine("Hello my name is " + Name);
	}

	public void CelebrateBirthday()
	{
		Age += 1;
		Console.WriteLine("Happy birthday, you are now " + Age + " years old");
	}
}
