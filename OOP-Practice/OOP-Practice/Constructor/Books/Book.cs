﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Constructor.Books;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

    public Book()
    {

    }
    public Book(string title)
    {
		Title = title;

	}
	public Book(string title, string author)
    {
		Title = title;
		Author = author;
	}
    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    public Book(Book book)
    {
        Title = book.Title;
        Author = book.Author;
        Price = book.Price;
    }



}
