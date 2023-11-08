namespace CarDealershipManager
{
    public class Car
    {
        private string colour;
        private string make;
        private string model;
        private int year;

        // Constructor
        public Car(string colour, string make, string model, int year)
        {
            Colour = colour;
            Make = make; // Using the property ensures that the set validation is applied
            Model = model;
            Year = year;
        }

        // Public getter and private setter for Colour
        public string Colour
        {
            get { return colour; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    colour = value;
                }
                else
                {
                    throw new ArgumentException("Colour cannot be null or whitespace.");
                }
            }
        }

        // Public getter and private setter for Make
        public string Make
        {
            get { return make; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    make = value;
                }
                else
                {
                    throw new ArgumentException("Make cannot be null or whitespace.");
                }
            }
        }

        // Public getter and private setter for Model with validation
        public string Model
        {
            get { return model; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentException("Model cannot be null or whitespace.");
                }
            }
        }

        // Public getter and private setter for Year with validation
        public int Year
        {
            get { return year; }
            private set
            {
                if (value > 0 && value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException("Year is not valid.");
                }
            }
        }

        // Respray function for changing colour, also implements the setter's input validation
        public void Respray(string newColour)
        {
            Colour = $"{newColour} (previously {Colour})";
        }

        // Method to display car information
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Colour: {Colour}, Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }

    public class Dealership
    {
        private List<Car> inventory;
        private decimal dealershipBalance;

        public decimal DealershipBalance
        {
            get => dealershipBalance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Dealership cannot have a negative balance.");
                }
                dealershipBalance = value;
            }
        }

        public Dealership(decimal startingBalance)
        {
            inventory = new List<Car>();
            dealershipBalance = startingBalance;
        }

        protected void AddCar(Car newVehicle)
        {
            if (newVehicle == null)
            {
                throw new ArgumentNullException("Cannot add a null vehicle to the inventory");
            }
            inventory.Add(newVehicle);
        }

        protected void RemoveCar(string colour, string make, string model, int year) 
        { 
            for (int i = 0; i < inventory.Count; i++)
            { 
                Car car = inventory[i];
                if (car.Colour == colour && car.Make == make && car.Model == model && car.Year == year)
                {
                    inventory.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Could not find the vehicle to remove");
        }

        public bool PurchaseVehicle(Car newVehicle, decimal price)
        {
            if (price < 0)
            {
                return false;
            }

            try
            {
                DealershipBalance -= price;
            }
            catch { return false; }

            try
            {
                this.AddCar(newVehicle);
                return true;
            }
            catch 
            {
                DealershipBalance += price; // Undo purchase
                return false; 
            }
        }

        public bool SellVehicle(string colour, string make, string model, int year, decimal price)
        {
            if (string.IsNullOrEmpty(colour) || string.IsNullOrEmpty(make) || string.IsNullOrEmpty(model) || price < 0)
            {
                return false;
            }

            try
            {
                DealershipBalance += price;
            }
            catch { return false; }

            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].Colour == colour &&
                    inventory[i].Make == make &&
                    inventory[i].Model == model &&
                    inventory[i].Year == year)
                {
                    try 
                    {
                        RemoveCar(inventory[i].Colour, inventory[i].Make, inventory[i].Model, inventory[i].Year);
                        return true;
                    }
                    catch
                    {
                        DealershipBalance -= price;
                        return false;
                    }
                }
            }
            DealershipBalance -= price;
            return false;
        }

        public bool ResprayCar(string colour, string make, string model, int year, string newColour)
        {
            if (string.IsNullOrEmpty(colour) || string.IsNullOrEmpty(make) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(newColour)) 
            { 
                return false; 
            }

            for (int i = 0; i < inventory.Count; i++)
            {
                Car car = inventory[i];
                if (inventory[i].Colour == colour &&
                    inventory[i].Make == make &&
                    inventory[i].Model == model &&
                    inventory[i].Year == year)
                {
                    inventory[i].Respray(newColour);
                    return true;
                }
            }
            return false;
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"There are {inventory.Count} vehicles in the inventory:");
            foreach (Car car in inventory)
            {
                car.DisplayCarInfo();
            }
        }

        public int GetInventorySize()
        {
            return inventory.Count;
        }

        public void SearchInventory(string colour, string make, string model, Nullable<int> year)
        {
            bool results = false;
            for (int i = 0; i < inventory.Count; i++)
            {
                Car car = inventory[i];
                if ((car.Colour == colour || string.IsNullOrEmpty(colour)) &&
                    (car.Make == make || string.IsNullOrEmpty(make)) &&
                    (car.Model == model || string.IsNullOrEmpty(model)) &&
                    (car.Year == year || year == null))
                {
                    inventory[i].DisplayCarInfo();
                    results = true;
                }
            }

            if (!results)
            {
                Console.WriteLine("No results found...");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myDealership = new Dealership(23000);
            Console.WriteLine($"Current dealership balance: ${myDealership.DealershipBalance}\n");

            var myCar = new Car("White", "Kia", "Rio", 2014);
            myDealership.PurchaseVehicle(myCar, 9500);
            Console.WriteLine($"Purchased {myCar.Year} {myCar.Make} {myCar.Model} for $9500");
            Console.WriteLine($"Current dealership balance: ${myDealership.DealershipBalance}\n");

            myCar = new Car("Red", "Kia", "Cerato", 2018);
            myDealership.PurchaseVehicle(myCar, 12000);
            Console.WriteLine($"Purchased {myCar.Year} {myCar.Make} {myCar.Model} for $120000");
            Console.WriteLine($"Current dealership balance: ${myDealership.DealershipBalance}\n");

            myDealership.DisplayInventory();
            myDealership.ResprayCar("White", "Kia", "Rio", 2014, "Black");
            Console.WriteLine("");
            myDealership.DisplayInventory();
            Console.WriteLine($"\nSold {myCar.Year} {myCar.Make} {myCar.Model} for $15000");
            myDealership.SellVehicle("Red", "Kia", "Cerato", 2018, 15000);
            Console.WriteLine($"Current dealership balance: ${myDealership.DealershipBalance}");
        }
    }
}


