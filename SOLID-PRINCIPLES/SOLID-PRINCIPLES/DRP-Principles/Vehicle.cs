using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES.DRP_Principles;
/**
	* Vehicle Attributes
	* Brand, Model, Model Type( EG Mercedes = Brand; A = Model; 180 Model Type)
	* Engine Specs / Type (Type: inline, V, Boxer) NA or Forced Induction
	* Occupants
	* Car Type: Sedan, Hatchback, Limo, SUV, Coupe
	* Transmission Type (Auto/Manual/DCT)
	* Fuel Type ([Homo-> Electric], Fuel/Gasoline, Diesel)
	* Dimentions
   */
// this is I am practicing myself from my own scenrio to check my knowledge
// first I want to create Inheritence 
//then apply Single Responsibiily Principle, created extra class to manage Vehicle
//Then Apply OCP
// apply ISP, LSP, Finally DIP

//This is a vehicle Company where they focuns on to build car, truck and motorcycle, Every has specific features

public enum TruckUsage { Food, Oil, Logistics}
public enum AutoUsage { Personal, Family }
public enum EngineType { Inline, V, Boxer, Forced}
public enum CarType { Sedan, Hatchback , Limo , SUV , Coupe }
public enum FuelType {Home, Fuel, Diesel}
public class Vehicle
{
    public int ID { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
	public string? ModelType { get; set; }
	public int Year { get; set; }
   

}
public class Dimension
{
    public int ID { get; set; }
    public decimal Length { get; set; }
    public decimal Height { get; set; }
    public decimal Width { get; set; }
}
public class Engine
{
    public int ID { get; set; }
    public EngineType EngineType { get; set; }
}
public class Truck: Vehicle
{
    public TruckUsage Usage { get; set; }
	public Truck():base()
    {
        Console.WriteLine(" Creating Truck Car Objects");
    }
 
}
public class Auto:Vehicle
{
    public AutoUsage Usage { get; set; }
    public Auto():base()
    {
        Console.WriteLine("Creating Auto Car Objects");
    }
}

public class MotorCycle : Vehicle
{

}
public class VehicleService
{
    private List<Vehicle> _vehicles;
    public void CreateNewVehicle(Vehicle vehicle)
    {
		_vehicles = new List<Vehicle>();
        _vehicles.Add(vehicle);
    }
    public void UpdateVehicle(Vehicle vehicle)
    {
        
    }

    public List<Vehicle> GetVehicles()
    {
        return _vehicles;
    }

    public void DeleteVehicle()
    {
     
    }
}
