using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Polymorphism;

public class Calculator
{
	public int Add(int a, int b)
	{
		return a + b;
	}
	public double Add(double a, double b)
	{
		return a + b;
	}
	public string Add(string a, string b)
	{
		return a + b;
	}
}
