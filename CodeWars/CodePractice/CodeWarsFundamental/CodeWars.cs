namespace CodeWarsFundamental
{
	public class CodeWars
	{

		/// <summary>
		/// Implement a function which convert the given boolean value into its string representation.
		/// Note: Only valid inputs will be given.
		/// </summary>
		/// <param name="b"></param>
		/// <returns></returns>
		/// 01
		public string BooleanToString(bool b)
		{
			if (b)
			{

				return "True";
			}
			else
			{

				return "False";
			}
			//return b ? "True" : "False";

		}
		/// 02
		public string Bmi(double weight, double height)
		{
			double calculatedBmi = weight / (height * height);
			if (calculatedBmi <= 18.5)
			{
				return "Underweight";
			}
			if (calculatedBmi <= 25.0)
			{
				return "Normal";
			}
			if (calculatedBmi <= 30.0)
			{
				return "Overweight";
			}
			if (calculatedBmi > 30)
			{
				return "Obese";
			}
			return "";

		}
	}
}
