using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance;

public class Manager : Employee
{
    public int ManagedTeamSize { get; set; }
    public void EmployeeInfo()
	{
		Console.WriteLine("Employee Name" + EmplyeeName);
		Console.WriteLine("Employee Id" + EmplyeeID);
	}
	public void LeadTeam()
	{
        Console.WriteLine("Leading a team of" +ManagedTeamSize);
    }
}
