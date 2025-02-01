namespace SOLID_PRINCIPLES;

public class Program
{
	static void Main(string[] args)
	{
		Idatabase idatabase = new MySQLDatabase();  //using Polymorphism

		Idatabase idatabase1 = new PostgreSqlDatabase();

		EmployeeService employeeService = new EmployeeService(idatabase);
		employeeService.SaveEmployee("Employee data saving to the MySQLDatabase");
		EmployeeService employeeService1 = new EmployeeService(idatabase1);
		employeeService1.SaveEmployee("Employee data saving  to the PostgreSQL databas");

	}
}
