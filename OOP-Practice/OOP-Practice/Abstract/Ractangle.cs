﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Abstract;

public class Ractangle : Shape
{
	public double Width { get; set; }
	public double Height { get; set; }
	public override double Area()
	{
		return Width * Height;
	}
}
