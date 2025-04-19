namespace CompanyInterviews
{
	public class InterviewCompany
	{
		//IDEAL

		private static void LicensePlateRandom()
		{
			string LicensePlate = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				int randomindex = random.Next(LicensePlate.Length);
				Console.Write(LicensePlate[randomindex]);
			}

		}
		private static void Greet()
		{
			Console.WriteLine("Hello Word");
		}

		private static void LicensePlateFriendApproach()
		{
			Random? rnd = new Random();
			string licensePlate = "";
			char randAlpha;

			int letterAmmount = rnd.Next(0, 5);
			int numDigit = 5 - letterAmmount;
			for (int i = 0; i < letterAmmount; i++)
			{
				randAlpha = (char)rnd.Next('A', 'Z');
				licensePlate += randAlpha;
			}
			for (int i = 0; i < numDigit; i++)
			{
				randAlpha = (char)rnd.Next('0', '9');
				licensePlate += randAlpha;
			}
			Console.WriteLine(licensePlate);
		}
		//asked question heap and stack in c#
		//TDD
		//benefits to write down test first
		//SIOUX Planning
		private static void CheckUnique()
		{
			List<int> numbers = new List<int>();
			Random rnd = new Random();
			int number = rnd.Next(0, 11);
			numbers.Add(number);
			Dictionary<int, int> numberCount = new Dictionary<int, int>(); //collection of key and value pair
			int checkUnique = 0;
			for (int i = 0; i < 10; i++)
			{
				number = rnd.Next(0, 11);
				numbers.Add(number);
			}
			foreach (var item in numbers)
			{
				Console.WriteLine(item);
			}

			for (int i = 0; i < numbers.Count; i++)
			{
				if (numberCount.ContainsKey(numbers[i]))
				{
					numberCount[numbers[i]] += 1;
				}
				else
				{
					numberCount.Add(numbers[i], 1); //something need to have add method with else statement
				}


			}
			foreach (var item in numberCount)
			{
				Console.WriteLine(item.Key + " " + item.Value);
				if (item.Value == 1)
				{
					checkUnique = item.Key;
					Console.WriteLine("unique number" + checkUnique);
					break;
				}
			}
			//if (numberCount.Conta)
			//{
			//	checkUnique = numberCount.FirstOrDefault(x => x.Value == 1).Key;
			//	Console.WriteLine(" unique number" + checkUnique);
			//	return;
			//}


		}
		private static void FriendApproach()
		{
			bool isUnique = false;
			List<int> numbers = new List<int>() { 1, 1, 3, 3, 4, 5, 5, 6, 6, 6 };
			for (int i = 0; i < numbers.Count; i++)
			{
				int checkunique = 0;

				for (int j = 0; j < numbers.Count; j++)
				{
					if (numbers[i] == numbers[j])
					{
						checkunique++;
					}

				}
				if (checkunique == 1)
				{
					isUnique = true; ;
					Console.WriteLine("unique number" + numbers[i]);
				}

			}
			if (isUnique == false)
			{
				Console.WriteLine("No unique number");
			}



		}
	}
}
