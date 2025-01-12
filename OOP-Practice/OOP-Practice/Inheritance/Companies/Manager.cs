using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance.Companies;

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
        Console.WriteLine("Leading a team of" + ManagedTeamSize);
    }
	public override void Work()
	{
		base.Work();
        Console.WriteLine("Managing team of"+ManagedTeamSize);
    }
}
