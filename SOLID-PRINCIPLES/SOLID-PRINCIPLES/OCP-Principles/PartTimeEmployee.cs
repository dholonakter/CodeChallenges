using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES;

public class PartTimeEmployee : Employee, IEmployee, IBonus
{
	public void CalculateSalary()
	{
		Salary = Salary * 1.5;
	}
	public double GetBonus()
	{
		return Salary * 0.1;
	}

}
