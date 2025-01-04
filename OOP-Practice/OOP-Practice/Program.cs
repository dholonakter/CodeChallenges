using System;
using System.Runtime.InteropServices;

namespace OOP_Practice;

public class Program
{
	static void Main(string[] args)
	{
		Person person1 = new Person("Dola", 20);
		Console.WriteLine("Before Update" + person1.Age);
		person1.UpdatePerson(person1);
		Console.WriteLine("After Update" + person1.Age);

		MathHelper.Add(10, 2);
		MathHelper.Divide(10, 2);
		MathHelper.Multiply(10, 2);

		Book book = new Book
		{
			Title = "Good book",
			Author = "James clear",
			Price = 20
		};
		Console.WriteLine("Book " + book.Title + "Author" + book.Author + "Price" + book.Price);

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
	}
}
