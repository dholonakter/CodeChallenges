using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES;

public interface IEmployee
{
	public void CalculateSalary();
}
public interface IBonus
{
	public double GetBonus();

}
