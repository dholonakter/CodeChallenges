using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Constructor.Books;

public static class Library
{
    public static int TotalBooks { get; private set; }
    static Library()
    {
        TotalBooks = 0;
    }
    public static void AddBook()
    {
        TotalBooks++;
        Console.WriteLine("Total number of Books " + TotalBooks);
    }

}
