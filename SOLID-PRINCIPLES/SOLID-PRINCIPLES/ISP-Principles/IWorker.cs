using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES;

//Interface Segregation Principle(ISP)
public interface IWorker
{
	public void Work();

}
public interface IEatable
{
	public void Eat();

}
public class Robot : IWorker
{

	public void Work()
	{
		Console.WriteLine("Robot is Working");
	}
}
public class HumanWorker : IWorker, IEatable
{
	public void Eat()
	{
		Console.WriteLine("Human is eating");
	}

	public void Work()
	{
		Console.WriteLine("Human is working");

	}
}
