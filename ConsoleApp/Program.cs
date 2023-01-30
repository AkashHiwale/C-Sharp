using Basics.Arrays;
using Basics.ConditionStatements;
using Basics.Iteration;
using Basics.Lists;
using Basics.Strings;
using CommonHelper;

namespace ConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");

        /*#region ConditionalStatements
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
        #endregion*/

       /* #region Iteration
        //EvenNumbers
        Console.Write("Please enter a number till which you want to receive even numbers: ");
        int evenNumberInput = TypeConversion.StringToInt(Console.ReadLine());
        Console.WriteLine(Iteration.EvenNumbers(evenNumberInput));

        //OddNumbers
        Console.Write("Please enter a number till which you want to receive odd numbers: ");
        int oddNumberInput = TypeConversion.StringToInt(Console.ReadLine());
        Console.WriteLine(Iteration.OddNumbers(oddNumberInput));

        //DivisibleRangeCount
        Console.Write("Please enter a number to check how many numbers are divible by it from 1 to 100: ");
        int num = TypeConversion.StringToInt(Console.ReadLine());
        Console.WriteLine(Iteration.DivisibleRangeCount(num));

        //Factorial
        Console.Write("Please enter a number to check to calculate it's factorial: ");
        int factorialNumber = TypeConversion.StringToInt(Console.ReadLine());
        Console.WriteLine(Iteration.Factorial(factorialNumber));

        //FindMaximum
        Console.Write("Please enter comma separated numbers to find maximum: ");
        string commaSeparatedNumbers = Console.ReadLine();
        Console.WriteLine(Iteration.FindMaximum(commaSeparatedNumbers));
        #endregion*/

        /*#region Array
        //ReverseString
        Console.Write("Enter a name to reverse: ");
        string nameToReverse = Console.ReadLine();
        Console.WriteLine(Arrays.ReverseString(nameToReverse));
        #endregion*/

        /*#region Lists
        //SmallestNumbers
        Console.Write("Enter comma separated list of numbers to find three smallest numbers: ");
        string listOfNumbers = Console.ReadLine();
        Console.WriteLine(Lists.SmallestNumbers(listOfNumbers));
        #endregion*/

        /*#region Strings
        //CheckForConsecutiveNumbers
        Console.Write("Please enter consecutive numbers separated by '-': ");
        string consecutiveNumbersInput = Console.ReadLine();
        Console.WriteLine(StringManipulation.CheckForConsecutiveNumbers(consecutiveNumbersInput));

        //CheckForDuplicateNumber
        Console.Write("Please enter consecutive numbers separated by '-': ");
        string duplicateNumbersInput = Console.ReadLine();
        Console.WriteLine(StringManipulation.CheckForDuplicateNumber(duplicateNumbersInput));

        //MakeStringPascalCase
        Console.Write("Please enter few words separated by ' ': ");
        string words = Console.ReadLine();
        Console.WriteLine(StringManipulation.MakeStringPascalCase(words));
        #endregion*/
    }
}