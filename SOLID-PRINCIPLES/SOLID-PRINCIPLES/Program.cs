using SOLID_PRINCIPLES.DRP_Principles;

namespace SOLID_PRINCIPLES;

public class Program
{
	static void Main(string[] args)
	{
		// Vehicle
		VehicleService vs = new VehicleService();
		Vehicle vehicle = new Truck();
		Vehicle vehicle2 = new Auto();

		vs.CreateNewVehicle(vehicle);
		vs.CreateNewVehicle(vehicle2);
		
		Cat cat = new Cat();
		cat.MakeSound();
	

		Idatabase idatabase = new MySQLDatabase();  //using Polymorphism

		Idatabase idatabase1 = new PostgreSqlDatabase();

		EmployeeService employeeService = new EmployeeService(idatabase);
		employeeService.SaveEmployee("Employee data saving to the MySQLDatabase");
		EmployeeService employeeService1 = new EmployeeService(idatabase1);
		employeeService1.SaveEmployee("Employee data saving  to the PostgreSQL databas");


	}
}
