using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Constructor.Books;

public static class MathHelper
{
    public static int Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum " + sum);
        return sum;
    }
    public static int Divide(int a, int b)
    {
        int divide = a / b;
        Console.WriteLine("Divide " + divide);
        return divide;
    }
    public static int Multiply(int a, int b)
    {
        int multiply = a * b;
        Console.WriteLine("Multiply " + multiply);
        return multiply;
    }
}
