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