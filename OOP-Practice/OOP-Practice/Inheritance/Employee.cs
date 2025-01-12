using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance;

public class Employee:Person
{
	protected internal string EmplyeeName { get; set; }
	protected internal int EmplyeeID { get; set; }
	public void Work()
	{
        Console.WriteLine("working hard");
    }
}
