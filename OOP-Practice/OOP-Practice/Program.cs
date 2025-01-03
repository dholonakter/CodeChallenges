using System;
using System.Runtime.InteropServices;

namespace OOP_Practice
{
	public class Program
	{
		static void Main(string[] args)
		{
			Person FirstPerson = new Person();
			FirstPerson.Name = "Dholon";
			FirstPerson.Age = 30;

			Person SecondPerson = new Person();
			SecondPerson.Name = "Nila";
			SecondPerson.Age = 20;

			Person ThirdPerson = new Person("Nisa", 25);

			Student FirstStudent = new Student();
			FirstStudent.Name = "Jany";
			FirstStudent.Age = 32;
			FirstStudent.Grade = "A";
			FirstStudent.SayHello();
			FirstStudent.Study();

			FirstPerson.CelebrateBirthday();	
			FirstPerson.SayHello();
			SecondPerson.SayHello();
			SecondPerson.CelebrateBirthday();
			ThirdPerson.SayHello();
			ThirdPerson.CelebrateBirthday();

			FootballPlayer footballPlayer = new FootballPlayer();
			footballPlayer.Play();
			Guitarist guitarist = new Guitarist();
			guitarist.Play();

			Person person = new Person();
            Console.WriteLine("person name "+person.Name+ "person age "+ person.Age);
			person.SayHello();
			person.CelebrateBirthday();
        }
	}
}
