namespace Encapsulated_Car
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
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }
}