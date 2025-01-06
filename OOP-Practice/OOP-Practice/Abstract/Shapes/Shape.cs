using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Abstract.Shapes;

public abstract class Shape
{
    public string Name { get; set; }
    public abstract double Area();

    protected Shape()
    {
        
    }
    public void ShapeName()
    {
        Console.WriteLine("Name" +Name);
    }

}

