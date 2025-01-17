using System.Collections.Generic;

namespace LINQ_Practices;

public class Program
{
	static void Main(string[] args)
	{
		FindNumbersGreaterThanTen();
		FindNameStartWithA();
		IsEven();
		FindNumbersGreaterThanFifity();
		GetStringWithFIveChar();
		GetNumbersGreaterThanTwenty();
		CheckProductCost();
		GetNumbersByDesc();
		CalculateNumbers();
		GroupWordsByLength();
		FindMaxValue();
		Practice12();
		FirstOrDefaultorSingle();
	}
	//--------------------Practice-1------------------------------------

	static List<int> FindNumbersGreaterThanTen()
	{
		List<int> numbers = new List<int>() { 5, 12, 3, 20, 8, 25, 7 };

		var find_numbers = numbers.Where(x => x > 10).ToList();

		foreach (int number in find_numbers)
		{
			Console.WriteLine(number);
		}
		return find_numbers;
	}
	//--------------------Practice-2------------------------------------
	static List<string> FindNameStartWithA()
	{
		List<string> names = new List<string> { "Alice", "Bob", "Anna", "Charlie", "Andrew" };
		var find_names = names.Where(name => name.StartsWith("A")).ToList();
		foreach (var name in find_names)
		{
			Console.WriteLine(name);
		}
		return find_names.ToList();
	}
	//--------------------Practice-3------------------------------------
	static bool IsEven()
	{
		List<int> numbers = new List<int> { 3, 5, 7, 9, 11 };
		var check_even = numbers.Any(x => x % 2 == 0);
		Console.WriteLine(check_even);
		return check_even;
	}
	//--------------------Practice-4------------------------------------

	static int FindNumbersGreaterThanFifity()
	{
		List<int> numbers = new List<int> { 10, 20, 30, 40 };
		var find_number = numbers.FirstOrDefault(number => number > 50, -1);
		Console.WriteLine(find_number);
		return find_number;
	}
	//--------------------Practice-5------------------------------------
	static string GetStringWithFIveChar()
	{
		List<string> words = new List<string> { "apple", "banana", "grape", "peach" };
		var find_words = words.Where(word => word.Length == 5).ToList();

		if (find_words.Count == 1)
		{
			return find_words[0];
		}
		else
		{
			return null;
		}
	}

	//--------------------Practice-6------------------------------------
	static void GetNumbersGreaterThanTwenty()
	{
		List<int> numbers = new List<int> { 10, 15, 25, 30, 35, 40, 22 };
		var find_numbers = numbers.Where(x => x > 20 && x % 5 == 0).ToList();
		foreach (var number in find_numbers)
		{
			Console.WriteLine(number);
		}

	}
	//--------------------Practice-7------------------------------------

	static bool CheckProductCost()
	{
		List<Product> products = new List<Product>
		{
			new Product{ID=1, Name="Laptop", Price=1500},
			new Product{ID=2, Name="Laptop", Price=20},
			new Product{ID=3, Name="Laptop", Price=1500},
		};
		var check_price = products.Any(p => p.Price > 300);
		Console.WriteLine(check_price);
		return check_price;
	}
	//--------------------Practice-8------------------------------------
	static void GetNumbersByDesc()
	{
		List<int> numbers = new List<int> { 4, 10, 1, 7, 3 };
		var get_numbers = numbers.OrderByDescending(number => number);
		foreach (var number in get_numbers)
		{
			Console.WriteLine(number);
		}

	}
	//--------------------Practice-9------------------------------------
	static void CalculateNumbers()
	{
		List<int> numbers = new List<int> { 3, 5, 7, 9 };
		var sum = numbers.Sum();
		Console.WriteLine(sum);
	}
	//--------------------Practice-10------------------------------------
	static void GroupWordsByLength()
	{
		List<string> words = new List<string> { "cat", "dog", "elephant", "tiger", "ant" };
		var check_length = words.GroupBy(word => word.Length);
		foreach (var word in check_length)
		{
			Console.WriteLine("Length " + word.Key);
			foreach (var item in word)
			{
				Console.WriteLine(item);
			}

		}
	}
	//--------------------Practice-11------------------------------------

	static void FindMaxValue()
	{
		List<int> numbers = new List<int> { 18, 42, 7, 99, 34 };
		var max_value = numbers.Max();
		Console.WriteLine(max_value);
	}
	//--------------------Practice-12------------------------------------

	static void Practice12()
	{
		List<int> numbers = new List<int> { 18, 42, 7, 99, 34 };
		var check_number = numbers.Contains(9);
		Console.WriteLine(check_number);
		var check_avearage = numbers.Average();
		Console.WriteLine(check_avearage);
		var check_amount = numbers.Count();
		Console.WriteLine(check_amount);
		var check_last = numbers.Last();

	}
	static void FirstOrDefaultorSingle()
	{
		List<int> numbers = new List<int> { 7, 10, 21, 30, 45, 50, 87 };
		List<string> string_list = new List<string>() { "null", "One", "Two", "Three", "Four" };
		List<string> emptyList = new List<string>();

		var check_numbers = numbers.First();
		Console.WriteLine("check number " + check_numbers);
		var check_string = string_list.First();
		Console.WriteLine("check string " + check_string);
		var check_empty = emptyList.FirstOrDefault();
		Console.WriteLine("check error " + check_string);

	}
}
public class Product
{
	public int ID { get; set; }
	public string Name { get; set; }
	public decimal Price { get; set; }

}
