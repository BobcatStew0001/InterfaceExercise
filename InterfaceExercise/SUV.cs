using System;

namespace InterfaceExercise;

public class SUV : ICompany, IVehicle
{
    public string ThirdRowSeat { get; set; }
    
    public string PowerRearHatch { get; set; }

    public int NumberOfTires { get; set; }
    
    public double Price { get; set; }
    
    public string Fuel { get; set; }
    
    public string FourWheelDrive { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"This SUV has {NumberOfTires} tires, a {PowerRearHatch}, and a {ThirdRowSeat}" +
                          $" all for the low {Price:C}. It is {FourWheelDrive} so it does use a tad bit more {Fuel}");
    }
}