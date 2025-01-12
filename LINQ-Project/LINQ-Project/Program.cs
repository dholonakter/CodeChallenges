namespace LINQ_Project;

public class Program
{
	static void Main(string[] args)
	{
		Student[] studentArray = {
			new Student() { StudentId = 1, StudentName = "Dola", Age = 29 },
			new Student() { StudentId = 2, StudentName = "Sakib", Age = 16 },
			new Student() { StudentId = 3, StudentName = "Jan", Age = 20 },
			new Student() { StudentId = 4, StudentName = "Sira", Age = 21 },
			new Student() { StudentId = 5, StudentName = "Jack", Age = 25 },
			new Student() { StudentId = 5, StudentName = "Jack", Age = 12 },
			new Student() { StudentId = 5, StudentName = "Jack", Age = 13 }

		};

		int i = 0;
		Student[] students = new Student[10];
		foreach (Student student in studentArray)
		{
			if (student.Age >= 20 && student.Age <= 25)
			{
				students[i] = student;
				i++;
				Console.WriteLine("Print the array of Students " + student.StudentName + "Age" + student.Age);
			}
		}
		// finding the teenange students

		var teenageStudents= from student_list in studentArray
							 where student_list.Age>=12 && student_list.Age <= 20
							 select student_list;

		var teenageStudents1 = studentArray.Where(s => s.Age >= 12 && s.Age <= 19).ToList<Student>();

		Console.WriteLine("List of teenage student" +teenageStudents.Count());

		foreach (Student student in teenageStudents)
		{
            Console.WriteLine("Name" + student.StudentName + student.Age);
        }

        //Data Source
        string[] names = { "dola", "steve", "Jay", "Akash" };

		//LINQ query Syntax
		var myLinqQuery = from name in names
						  where name.Contains('a')
						  select name;

		foreach (var name in names)
		{
			Console.WriteLine("name " + name);
		}

		//Linq Query Practice
		List<String> tutorials = new List<string>()
		{
		  "C# Tutorials",
		  "Java Tutorials",
		  "Python",
		  "C++"
		};

		IEnumerable<string>? results = from langauge in tutorials where langauge.Contains("Tutorials") select langauge;
		//method syntax
		var result1 = tutorials.Where(s => s.Contains("Tutorials"));


		foreach (var result in results)
		{
            Console.WriteLine(result);
        }


	}
}
