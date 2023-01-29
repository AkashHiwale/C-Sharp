namespace Basics.Lists;

public class Lists
{
    public static string SmallestNumbers(string numbers)
    {
        string smallestNumbers = string.Empty;
        var list = numbers.Split(",").ToList();
        if(list.Count == 0)
        {
            return "Invalid Input.";
        }
        var listOfNumbers = new List<int>();
        foreach (var item in list)
        {
            listOfNumbers.Add(Convert.ToInt16(item));
        }
        listOfNumbers.Sort();
        var count = 0;
        foreach(var item in listOfNumbers)
        {
            if(count >= 3)
            {
                break;
            }
            smallestNumbers = smallestNumbers + item + ",";
            count++;
        }
        return smallestNumbers;
    }
}