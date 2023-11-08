We will declare an interface called `IChargeable`. This will contain one method `ChargeBattery()` that, when implemented, will handle the logic to charge the car's battery.
```csharp
using ObjectOrientedProgramming;

interface IChargeable
{
    void ChargeBattery();
}

class ChargeableElectricCar : ElectricCar, IChargeable
{
    public ChargeableElectricCar(string colour, string make, string model, int year, double batteryLevel) : base(colour, make, model, year, batteryLevel)
    {
        return;
    }
    
    public void ChargeBattery()
    {
        this.BatteryLevel = 100;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ChargeableElectricCar myChargeableElectricCar = new ChargeableElectricCar("White", "Kia", "Rio", 2014, 74.3);
        myChargeableElectricCar.DisplayCarInfo();
        myChargeableElectricCar.Respray("Black");
        myChargeableElectricCar.ChargeBattery();
        myChargeableElectricCar.DisplayCarInfo();
    }
}
```

The approach you've taken by creating a new class that inherits from `ElectricCar` and also implements `IChargeable` is known as _subclassing_ and it's a valid way to extend functionality without modifying the original class. This is particularly useful when you cannot or do not want to change the original class, such as when the class is part of a library that you do not control.

#### New Topics Covered:
- [[Interfaces]]
- [[Sub-classing]]