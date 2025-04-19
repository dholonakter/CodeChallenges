using CodeWarsFundamental;
using LeetcodeInterview;

namespace LeetCodeTest
{
	[TestFixture]
	public class Tests
	{


		public void Test1()
		{
			// Arrange
			var codeWars = new CodeWars();

			var expectedTrue = "True";
			var expectedFalse = "False";
			// Act
			var resultTrue = codeWars.BooleanToString(true);
			var resultFalse = codeWars.BooleanToString(false);
			// Assert
			Assert.That(resultTrue, Is.EqualTo(expectedTrue));
			Assert.That(resultFalse, Is.EqualTo(expectedFalse));

		}
		[Test]
		public void BmiTest()
		{

			var codeWars = new CodeWars();

			Assert.That(codeWars.Bmi(50, 1.80), Is.EqualTo("Underweight"), "For weight = 50 and height = 1.80");
			Assert.That(codeWars.Bmi(80, 1.80), Is.EqualTo("Normal"), "For weight = 80 and height = 1.80");
			Assert.That(codeWars.Bmi(90, 1.80), Is.EqualTo("Overweight"), "For weight = 90 and height = 1.80");
			Assert.That(codeWars.Bmi(100, 1.80), Is.EqualTo("Obese"), "For weight = 100 and height = 1.80");
		}
		[Test]
		public void Test2() 
		{
			var leetcode=new Leetcode();
		    Assert.That(leetcode.LengthOfLastWord("Hello World"), Is.EqualTo(5));
		}
	}
}