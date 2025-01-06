﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Polymorphism;

public class FootballPlayer:IPlayable
{
	public void Play()
	{
		Console.WriteLine("Playing the football");
	}
}
