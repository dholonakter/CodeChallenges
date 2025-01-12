using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance.Companies;

public class Department : Company
{
    public Department(string name)
    {
        CompanyName = name;
    }
    public void PrintName()
    {
        Console.WriteLine("Company name" + CompanyName);
    }
}
