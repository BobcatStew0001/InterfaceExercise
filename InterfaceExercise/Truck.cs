using System;

namespace InterfaceExercise;

public class Truck : ICompany, IVehicle
{
    public int BedLength { get; set; }
    
    public string CabSize { get; set; }
    

    public int NumberOfTires { get; set; }
    
    public double Price { get; set; }
    
    public string Fuel { get; set; }
        
    public string FourWheelDrive { get; set; }
    public void DisplayDetails()
    {
        Console.WriteLine($"This truck has {NumberOfTires} a {BedLength} and {CabSize} it runs off of {Fuel}" +
                          $"  and is {FourWheelDrive}. You can get all this for {Price:C}");
    }
}