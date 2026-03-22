using System;

namespace InterfaceExercise;

public class Car : ICompany, IVehicle
{
    public int NumberOfDoors { get; set; }
    
    public bool FrontWheelDrive { get; set; }
    
    public int NumberOfTires { get; set; }
    
    public double Price { get; set; }
    
    public string Fuel { get; set; }
    
    public string FourWheelDrive { get; set; }
    public void DisplayDetails()
    {
        Console.WriteLine($"This car has {NumberOfDoors} doors and {NumberOfTires} tires. It runs on {Fuel} and is {FrontWheelDrive}" +
                          $" All for the low price of {Price}");
    }
}