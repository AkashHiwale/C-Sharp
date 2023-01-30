namespace Basics.Strings;

public class StringManipulation
{
    public static string CheckForConsecutiveNumbers(string input)
    {
        var list = input.Split("-").ToList();
        var listOfNumbers = new List<int>();

        foreach(var number in list)
        {
            listOfNumbers.Add(Convert.ToInt32(number));
        }

        int previousNumber = 0;
        bool firstIteration = true;
        string output = string.Empty;
        foreach(var number in listOfNumbers)
        {
            if (firstIteration)
            {
                previousNumber = number;
                firstIteration = false;
            }
            else if(number-1 == previousNumber)
            {
                previousNumber = number;
                continue;
            }
            else
            {
                output = "List of Numbers are not consecutive.";
                break;
            }
        }
        if (string.IsNullOrEmpty(output))
        {
            output = "List of Numbers are consecutive.";
        }
        return output;
    }

    public static string CheckForDuplicateNumber(string input)
    {
        var list = input.Split("-").ToList();
        var listOfNumbers = new List<int>();

        foreach (var number in list)
        {
            listOfNumbers.Add(Convert.ToInt32(number));
        }

        string output = string.Empty;
        bool firstIteration = true;
        int previousNumber = 0;
        foreach (var number in listOfNumbers)
        {
            if (firstIteration)
            {
                previousNumber = number;
                firstIteration = false;
            }
            else if (number == previousNumber)
            {
                output = "Duplicates found in the list.";
                break;
                
            }
            else
            {
                continue;
            }
        }
        if (string.IsNullOrEmpty(output))
        {
            output = "No duplicates found.";
        }
        return output;
    }

    public static string MakeStringPascalCase(string input)
    {
        string output = string.Empty;
        if (string.IsNullOrEmpty(input))
        {
            return "Invalid Input";
        }
        var listOfWords = input.Split(" ");

        foreach(var word in listOfWords)
        {
            output = output + word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }
        return output;
    }
}