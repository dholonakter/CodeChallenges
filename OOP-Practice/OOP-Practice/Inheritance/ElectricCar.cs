using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance;

public class ElectricCar:Vehicle
{
	public new void StartEngine()
	{
        Console.WriteLine("Electric motor started");
    }
}
