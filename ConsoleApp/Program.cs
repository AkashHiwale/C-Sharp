using Basics.ConditionStatements;
using Basics.Iteration;
using CommonHelper;

namespace ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");

        #region ConditionalStatements
        //TimesOfDay
        Console.Write("Please enter current hour between 1 and 24: ");
        int input = TypeConversion.StringToInt(Console.ReadLine());
        Console.WriteLine(ConditionStatements.TimesOfDay(input));

        //IsGoldCustomer
        Console.Write("Are you a gold member (true or false): ");
        bool isGoldCustomer = TypeConversion.StringToBool(Console.ReadLine());
        Console.WriteLine(ConditionStatements.IsGoldCustomer(isGoldCustomer));

        //WhichSeason
        Console.Write("Which season is it now? summer, winter or rainy? ");
        string season = Console.ReadLine();
        Console.WriteLine(ConditionStatements.WhichSeason(season));

        //IsNumberInRange
        Console.Write("Please enter any number between 1 and 10:");
        int number = TypeConversion.StringToInt(Console.ReadLine());
        Console.WriteLine(ConditionStatements.IsNumberInRange(number));

        //MaxNumber
        Console.Write("Please enter a number: ");
        int firstNumber = TypeConversion.StringToInt(Console.ReadLine());
        Console.Write("Please enter another number: ");
        int secondNumber = TypeConversion.StringToInt(Console.ReadLine());
        Console.WriteLine(ConditionStatements.MaxNumber(firstNumber, secondNumber));

        //IsImageLandscapeOrPortrait
        Console.Write("Please enter image height: ");
        int height = TypeConversion.StringToInt(Console.ReadLine());
        Console.Write("Please enter image width: ");
        int width = TypeConversion.StringToInt(Console.ReadLine());
        Console.WriteLine(ConditionStatements.ImageOrientation(height, width));
        #endregion

        #region Iteration
        //EvenNumbers
        Console.Write("Please enter a number till which you want to receive even numbers: ");
        int evenNumberInput = TypeConversion.StringToInt(Console.ReadLine());
        Console.WriteLine(Iteration.EvenNumbers(evenNumberInput));

        //OddNumbers
        Console.Write("Please enter a number till which you want to receive odd numbers: ");
        int oddNumberInput = TypeConversion.StringToInt(Console.ReadLine());
        Console.WriteLine(Iteration.OddNumbers(oddNumberInput));

        #endregion
    }
}