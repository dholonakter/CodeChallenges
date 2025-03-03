using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES;

public class FullTimeEmployee : Employee, IEmployee
{
	public void CalculateSalary()
	{
		Salary = Salary * 1.2;

	}
}
