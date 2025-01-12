using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Constructor;

public class Product
{
	internal string ProductName { get; set; }
	internal int ProductCode { get; set; }
	internal decimal Price { get; set; }

	public Product()
	{

	}
	public Product(string productName, decimal price)
	{
		ProductName = productName;
		Price = price;
	}

	public Product(string productName, int productCode, decimal price)
		: this(productName, price)
	{
		ProductCode = productCode;
	}


}
