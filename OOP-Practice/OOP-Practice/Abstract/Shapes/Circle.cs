using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Abstract.Shapes;

public class Circle : Shape, IShape
{
    public double Radius { get; set; }

    public Circle()
    {
        
    }
    public Circle(double radias)
    {
        Radius = radias;
    }
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
	public void GetInfo()
	{
		Console.WriteLine("This is a Circle");
	}
}
