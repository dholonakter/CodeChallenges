using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice;

public class Book
{
	public string Title { get; set; }
	public string Author { get; set; }
	public decimal Price { get; set; }

    public Book()
    {
        
    }
    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    public Book( Book book)
    {
        this.Title = book.Title;
        this.Author = book.Author;
        this.Price = book.Price;
    }

	

}
