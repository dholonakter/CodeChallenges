using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Inheritance.People;

public class Student : Person
{
    public string Grade { get; set; }

    public void Study()
    {
        Console.WriteLine("study hard for the next time");
    }
    public override void SayHello()
    {
        base.SayHello();
        Console.WriteLine(" and I am in grade" + Grade);
    }

}
