using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES;

public class DepencyInjectPractice
{
	//problem
}

public interface Idatabase
{
	public void Save(string data);

}
public class MySQLDatabase : Idatabase
{
	public void Save(string data)
	{
		Console.WriteLine("Saving data to MySQL Database...");
	}
}
public class PostgreSqlDatabase : Idatabase
{
	public void Save(string data)
	{
		Console.WriteLine("Saving data to PostGreSQL Database...");
	}
}
public class EmployeeService
{
	private readonly Idatabase _database;
	public EmployeeService(Idatabase idatabase)
	{
		_database = idatabase;
	}

	public void SaveEmployee(string employee_data)
	{
		_database.Save(employee_data);
	}

}
