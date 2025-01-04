using OOP_Practice.Abstract;
using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace OOP_Practice;

public class Program
{
	static void Main(string[] args)
	{
		Library.AddBook();

		Circle circle = new Circle { Radius = 5 };
		Ractangle ractangle = new Ractangle { Height = 10, Width = 20 };
		Console.WriteLine("Area of circle" + circle.Area());
		Console.WriteLine("Area of ractangle" + ractangle.Area());


		Person person1 = new Person("Dola", 20);
		Console.WriteLine("Before Update" + person1.Age);
		person1.UpdatePerson(person1);
		Console.WriteLine("After Update" + person1.Age);

		MathHelper.Add(10, 2);
		MathHelper.Divide(10, 2);
		MathHelper.Multiply(10, 2);

		Book book1 = new Book
		{
			Title = "Good book",
			Author = "James clear",
			Price = 20
		};
		Console.WriteLine("Book " + book1.Title + "Author" + book1.Author + "Price" + book1.Price);

		Book book2 = new Book(book1);
		Console.WriteLine("Book " + book2.Title + "Author" + book2.Author + "Price" + book2.Price);


		StudentGC gc = new StudentGC();
		gc.Name = "Alice";
		gc.Age = 20;

		BankAccount account = new BankAccount("Dholon", 100);
		account.Deposit(500);
		account.Withdraw(400);
		Console.WriteLine(" ÄccountName " + account.AccountHolder + " Balance " + account.Balance);

		Car car = new Car();
		car.Make = "Peugo";
		car.Model = "208";
		car.Year = 2021;
		car.DisplayInfo();

		Person FirstPerson = new Person("Dholon", 10);

		Person SecondPerson = new Person("Ripa", 20);

		Person ThirdPerson = new Person("Nisa", 25);

		Student FirstStudent = new Student();

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
		Console.WriteLine("person name " + person.Name + "person age " + person.Age);
		person.SayHello();
		person.CelebrateBirthday();

		gc = null;
		GC.Collect();
		GC.WaitForPendingFinalizers();

		Console.WriteLine("End of Main method");
	}
}
