namespace InterfaceExercise;

public interface IVehicle
{
    public int NumberOfTires { get; set; }
    public double Price { get; set; }
    public string Fuel { get; set; }
    public string FourWheelDrive { get; set; }
    
    void DisplayDetails();
    
}