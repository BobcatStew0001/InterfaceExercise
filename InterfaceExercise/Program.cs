using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            var f150 = new Truck();
            f150.BedLength = 54;
            f150.Fuel = "Gasoline";
            f150.FourWheelDrive = "Yes";
            f150.CabSize = "Crew Cab";
            f150.NumberOfTires = 4;
            f150.Price = 65000;
            f150.NumberOfDealerships = "3000";
            f150.CompanyName = "Ford";
            f150.Logo = "Blue Oval";
            f150.Motto = "Built Ford Tough"; 
            
            
            var civic = new Car();
            civic.Fuel = "Gasoline";
            civic.FourWheelDrive = "No";
            civic.NumberOfTires = 4;
            civic.NumberOfDoors = 4; 
            civic.Price = 32000;
            civic.FrontWheelDrive = true;
            civic.NumberOfDealerships = "2600";
            civic.CompanyName = "Honda";
            civic.Logo = "Silver H";
            civic.Motto = "The Power of Dreams";
            
            var tahoe = new SUV();
            tahoe.Fuel = "Gasoline";
            tahoe.FourWheelDrive = "yes";
            tahoe.NumberOfTires = 4;
            tahoe.Price = 102000;
            tahoe.NumberOfDealerships = "3000";
            tahoe.CompanyName = "Chevy";
            tahoe.Logo = "Gold Bowtie";
            tahoe.Motto = "Like A Rock";
            tahoe.PowerRearHatch = "yes";
            tahoe.ThirdRowSeat = "yes";

            Console.WriteLine($"We are running some great deals on {f150.CompanyName} F-150's this week at Brandon Ford" +
                              $" the F-150 has a {f150.BedLength} inch bed {f150.NumberOfTires} tires" +
                              $" it runs on {f150.Fuel} or Electric. Come on down for a test drive in the {f150.CompanyName} F-150 {f150.CabSize}" +
                              $" This week we are knock $1000 off the {f150.Price:C} price tag. We are the #1 {f150.CompanyName} out of all {f150.NumberOfDealerships}" +
                              $" in the USA. So look for the {f150.Logo} off I-20 and remember the F-150 is {f150.Motto}");
            
            Console.WriteLine("_______________________________________________________________________");

            Console.WriteLine($"My wife drives a red {civic.CompanyName} civic. Some of her favorite things about the car are the distance she can travel on a " +
                              $" single tank of {civic.Fuel}, the {civic.NumberOfDoors}, which make it easy for the kids to get in and out at school" +
                              $" the {civic.NumberOfTires} that help it hold the road in sharp turns, and the ability to get it serviced at one of the over " +
                              $" {civic.NumberOfDealerships} across the country. Her {civic.CompanyName} really does {civic.Motto} and she is proud to show off" +
                              $" that {civic.Logo} when she is flying down the road");

            Console.WriteLine("____________________________________________________________________________________________");

            Console.WriteLine($"I have always wanted a {tahoe.CompanyName} tahoe, but the {tahoe.Price} price tag has always stopped me. " +
                              $" My dream tahoe is gunmetal gray. Is it 4wd {tahoe.FourWheelDrive} !, does it have a 3rd row seat {tahoe.ThirdRowSeat} !" +
                              $" will it have a power rear hatch {tahoe.PowerRearHatch} !. I want the {tahoe.Fuel} not the diesel or electric. " +
                              $" I need {tahoe.NumberOfTires} large mud tires for those early morning school drop-offs. I think I may stop by one of the {tahoe.NumberOfDealerships}" +
                              $" in the near future and purchase my Tahoe. It is {tahoe.Motto} after all and I do love a bowtie especially a {tahoe.Logo}. ");
            





            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
