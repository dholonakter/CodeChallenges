using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Abstract.Shapes;

public class Ractangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Ractangle()
    {
        
    }

    public Ractangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double Area()
    {
        return Width * Height;
    }
}
