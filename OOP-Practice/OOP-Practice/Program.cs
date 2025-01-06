using OOP_Practice.Abstract.Shapes;
using OOP_Practice.Constructor;
using OOP_Practice.Constructor.Books;
using OOP_Practice.Encapsulation;
using OOP_Practice.Inheritance.Animals;
using OOP_Practice.Inheritance.Companies;
using OOP_Practice.Inheritance.People;
using OOP_Practice.Inheritance.Vehicles;
using OOP_Practice.Polymorphism;
using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace OOP_Practice;

public class Program
{
	static void Main(string[] args)
	{
		dynamic person = new Person();
		dynamic employee = new Employee();
		person.SayHello();
		employee.SayHello();
		List<IShape> listshape = new List<IShape>
		 {
			 new Triangle(),
			 new Circle(),
			 new Square(),
		 };
		foreach (IShape shape in listshape)
		{
			shape.GetInfo();
		}
		
		Calculator calculator = new Calculator();
		Console.WriteLine(calculator.Add(2, 3));
		Console.WriteLine(calculator.Add(2.5, 3.5)); ;
		Console.WriteLine(calculator.Add("Hello", "World"));

		List<Shape> shapes = new List<Shape>();
		Ractangle ractangle1 = new Ractangle(5,4);
        Console.WriteLine("Area of ractangle " + ractangle1.Area());
		Circle circle1 = new Circle(3);
		Console.WriteLine("Area of circle " + circle1.Area());
		shapes.Add(circle1);
		shapes.Add(ractangle1);

		foreach (Shape shape in shapes)
		{
			Console.WriteLine(shape.Area()); ;
		}

		List<IPlayable> Players = new List<IPlayable>()
		{
			new FootballPlayer(),
			new Guitarist()
		};

        foreach (var playable in Players)
        {
            playable.Play();
        }


        Manager manager2 = new Manager();
		Developer developer = new Developer();
		manager2.ManagedTeamSize = 10;
		manager2.Work();
		developer.ProgrammingLanguage = "C#";
		developer.Work();

		Animal[] animals = new Animal[]
		{
			new Dog(),
			new Cat()
		};
		foreach (var animal in animals)
		{
			animal.MakeSound();
		}

		Manager manager1 = new Manager();
		manager1.SayHello();
		manager1.Work();
		manager1.LeadTeam();
		Vehicle vehicle = new Vehicle();
		vehicle.StartEngine();
		ElectricCar electricCar = new ElectricCar();
		electricCar.StartEngine();

		Customer customer = new Customer();
		customer.BankAccounts = new List<BankAccount>()
		{
			 new BankAccount("dola",100),
			 new BankAccount("saki",50),
			 new BankAccount("laki",60),
			 new BankAccount("taki",70),
		};

		customer.Withdraw(20, customer.BankAccounts[0]);
		customer.Deposit(50, customer.BankAccounts[1]);

		foreach (var item in customer.BankAccounts)
		{
			Console.WriteLine(item.AccountHolder + item.Balance);
        }


		Department department = new Department("Scherpthe");
		department.PrintName();
		Manager manager = new Manager();
		manager.EmplyeeName = "Dola";
		manager.EmplyeeID = 10;
		manager.EmployeeInfo();

		Dog dog = new Dog("Rox");
		dog.Bark();

		Product product = new Product("artcle1", 20);
		Product product1 = new Product("artcle1", 1, 21);
		Product product2 = new Product();
		product2.ProductName = "article3";

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

		Person person4 = new Person();
		Console.WriteLine("person name " + person4.Name + "person age " + person4.Age);
		person.SayHello();
		person.CelebrateBirthday();

		gc = null;
		GC.Collect();
		GC.WaitForPendingFinalizers();

		Console.WriteLine("End of Main method");
	}
}
