namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hour = 10;
            TimesOfDay(hour);

            bool isGoldCustomer = true;
            IsGoldCustomer(isGoldCustomer);

            string season = "winter";
            WhichSeason(season);

            Console.WriteLine("Enter a Number betweem 1 and 10: ");
            IsNumberInRange(Console.ReadLine());

            Console.WriteLine("Enter a Number: ");
            var a = Console.ReadLine();
            Console.WriteLine("Enter another Number: ");
            var b = Console.ReadLine();
            MaxNumber(IsValidNumber(a), IsValidNumber(b));

            Console.WriteLine("Enter height: ");
            var height = Console.ReadLine();
            Console.WriteLine("Enter width: ");
            var width = Console.ReadLine();
            IsImageLandscapeOrPortrait(IsValidNumber(height), IsValidNumber(width));
        }
        
        // If else conditional statements
        static void TimesOfDay(int hour)
        {
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour > 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }
        }

        // Conditional Operators
        static void IsGoldCustomer(bool isGoldCustomer)
        {
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine("Customer price is: "+ price);
        }

        // Switch Case Statements
        static void WhichSeason(string season)
        {
            switch (season)
            {
                case "summer":
                    Console.WriteLine("It's a summer season.");
                    break;
                case "winter":
                    Console.WriteLine("It's a winter season.");
                    break;
                case "rainy":
                    Console.WriteLine("It's a rainy sesaon.");
                    break;
                default:
                    Console.WriteLine("Sorry, I don't understand this season.");
                    break;
            }
        }

        // Method to check if number is a valid number
        static int IsValidNumber(string number)
        {
            int n;
            bool isNumber = Int32.TryParse(number, out n);
            if(isNumber)
            {
                return n;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return 0;
            }
        }

        // Method to check if a number is in valid range
        static void IsNumberInRange(string number)
        {
            int n = IsValidNumber(number);
            if(n>=1 && n<=10)
            {
                Console.WriteLine($"Number {n} is in valid range.");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        // Method to check maximum of two numbers
        static void MaxNumber(int a, int b)
        {
            if(a > b)
            {
                Console.WriteLine($"Number {a} is greater than {b}.");
            }
            else if (a < b)
            {
                Console.WriteLine($"Number {b} is greater than {a}.");
            }
            else
            {
                Console.WriteLine("Both the numbers are same.");
            }
        }

        // Method to check if the an image is landscape or protrait
        static void IsImageLandscapeOrPortrait(int height, int weight)
        {
            if(height > weight)
            {
                Console.WriteLine("Image is Portrait");
            }
            else if(height < weight)
            {
                Console.WriteLine("Image is Landscape");
            }
            else
            {
                Console.WriteLine("Image is square");
            }
        }
    }
}