Let's dive into the first task, where you will create a `Car` class and then instantiate it.
```csharp
using System;

namespace ObjectOrientedProgramming
{
    class Car
    {
        // properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Kia", "Rio", 2014);
            myCar.DisplayCarInfo();
        }
    }
}
```

#### New concepts covered in this program:
- [[Classes|Custom Classes]]
- [[Properties and Accessors]]
- [[Class Methods]]
- [[Main String Args|Main ( ) string array args]]