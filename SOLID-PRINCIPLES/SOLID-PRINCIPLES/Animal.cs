using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES;

public  class Animal
{
	public int ID { get; set; }
	public string Name { get; set; }
    public int Age { get; set; }

	public virtual void MakeSound()
	{

	}
	public virtual void CheckCareRequirements() { }
}
public class Dog:Animal
{
	public enum Breed { Labrador , German , Shepherd }
    public bool HasBeenWalked { get; set; }
    public Dog():base()
    {
        
    }
	public override void MakeSound()
	{
		Console.WriteLine("Woof");
	}
	public override void CheckCareRequirements()
	{
		Console.WriteLine("It has been walked", HasBeenWalked = true);
	}
}
public class Cat:Animal
{
	public enum Breed { Siamese, Persian, Ragdol }
	public bool HasBeenLitterTrained { get; set; }
	public Cat() : base()
	{

	}
	public override void MakeSound()
	{
		Console.WriteLine("Mew");
	}
	public override void CheckCareRequirements()
	{
		Console.WriteLine("It has been walked", HasBeenLitterTrained = true);
	}

}
public class Bird:Animal
{
	public enum Species { Canary, Parrot }
	public bool CanFly { get; set; }
    public Bird()
    {
        
    }
	public  void MakeSound()
	{
		Console.WriteLine("Chrip");
	}
	public  void CheckCareRequirements()
	{
        Console.WriteLine("It has been walked", CanFly=true);
    }


}
public class AnimalShelter
{
	private List<Animal> animals;
    public AnimalShelter()
    {
        animals= new List<Animal>();
    }
    public void AdmitAnimal(Animal animal)
    {
        animals.Add(animal);
    }
    
}