You've already created a `Car` class with basic properties and methods. Now, it's time to extend that class to create an `ElectricCar` that inherits from `Car`. Add a project reference so this project can reference the previous [[Custom Methods Program|Task 2]] namespace.

```csharp
using ObjectOrientedProgramming;

public class ElectricCar : Car
{
    private double batteryLevel;
    public double BatteryLevel
    {
        get => batteryLevel;
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(batteryLevel), "Battery charge must be between 0-100.");
            }
            batteryLevel = value;
        }
    }

    public ElectricCar(string colour, string make, string model, int year, double batteryLevel)
    : base(colour, make, model, year)
    {
        BatteryLevel = batteryLevel;
    }
    
    public override void DisplayCarInfo()
    {
        Console.WriteLine($"Colour: {Colour}, Make: {Make}, Model: {Model} (Electric), Year: {Year}, Battery: {BatteryLevel}%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ElectricCar myElectricCar = new ElectricCar("White", "Kia", "Rio", 2014, 74.3);
        myElectricCar.DisplayCarInfo();
        myElectricCar.Respray("Black");
        myElectricCar.DisplayCarInfo();
    }
}
```

#### New Topics Covered:
- [[Virtual Keyword]]
- [[Polymorphism]]
- [[Expression-bodied properties]]
