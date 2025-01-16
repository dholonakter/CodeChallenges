using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance.Companies;

public class Developer:Employee
{
    public string ProgrammingLanguage { get; set; }
    public override void Work()
	{
        base.Work();
        Console.WriteLine("developing in programming langauge" +ProgrammingLanguage);
    }
}
