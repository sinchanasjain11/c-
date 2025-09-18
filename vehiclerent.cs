using System;

namespace VehicleRentalService
{
    // Base class
    class Vehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public double RentalPricePerDay { get; set; }

        public Vehicle(string model, string brand, double pricePerDay)
        {
            Model = model;
            Brand = brand;
            RentalPricePerDay = pricePerDay;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand             : {Brand}");
            Console.WriteLine($"Model             : {Model}");
            Console.WriteLine($"Rental Price/Day  : ₹{RentalPricePerDay}");
        }
    }

    // Derived class
    class Car : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public string FuelType { get; set; } // e.g., Petrol, Diesel, Electric

        public Car(string model, string brand, double pricePerDay,
                   int seats, string fuelType)
            : base(model, brand, pricePerDay)
        {
            NumberOfSeats = seats;
            FuelType = fuelType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Seats   : {NumberOfSeats}");
            Console.WriteLine($"Fuel Type         : {FuelType}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Base vehicle example
            Vehicle bike = new Vehicle("R15", "Yamaha", 1200);
            Console.WriteLine("=== Vehicle Info ===");
            bike.DisplayInfo();

            Console.WriteLine();

            // Car example
            Car sedan = new Car("City", "Honda", 2500, 5, "Petrol");
            Console.WriteLine("=== Car Info ===");
            sedan.DisplayInfo();
        }
    }
}
