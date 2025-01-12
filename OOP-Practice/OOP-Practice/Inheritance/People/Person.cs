using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance.People;

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
	//Parameterless constructor
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
		Console.WriteLine("Hello my name is " + Name + "my age is" + Age);
	}

	public virtual void Introduce()
	{
        Console.WriteLine("Hello");
    }

	public void CelebrateBirthday()
	{
		Age += 1;
		Console.WriteLine("Happy birthday, you are now " + Age + " years old");
	}
	public void UpdatePerson(Person person)
	{
		person.Age += 1;
	}
}
