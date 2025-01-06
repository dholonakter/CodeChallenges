using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Abstract.Shapes;

public class Square:IShape
{
	public void GetInfo()
	{
		Console.WriteLine("This is a Square");
	}
}
