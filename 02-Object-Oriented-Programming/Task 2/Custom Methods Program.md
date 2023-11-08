```csharp
using System;

namespace ObjectOrientedProgramming
{
    class Car
    {
        // properties
        public string Colour { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        
        private int year;
        public int Year 
        { 
            get { return year; }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException(nameof(year), "Year must be positive.");
                }
            } 
        }
        
        public Car(string colour, string make, string model, int year)
        {
            Colour = colour;
            Make = make;
            Model = model;
            Year = year;
        }
        
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Colour: {Colour}, Make: {Make}, Model: {Model}, Year: {Year}");
        }
        
        public void Respray(string newColour)
        {
            Colour = $"{newColour} (previously {Colour})";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("White", "Kia", "Rio", 2014);
            myCar.DisplayCarInfo();
            myCar.Respray("Red");
            myCar.DisplayCarInfo();
        }
    }
}
```

#### New Topics Covered:
- 