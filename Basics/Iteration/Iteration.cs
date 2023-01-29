namespace Basics.Iteration;

public class Iteration
{
    public static string EvenNumbers(int n)
    {
        string output = string.Empty;
        for (var i=1; i < n; i++)
        {
            if(i%2 == 0)
            {
                output = output + i.ToString() + " ";
            }
        }
        return output;
    }

    public static string OddNumbers(int n)
    {
        string output = string.Empty;
        var numbers = new List<int>();
        for (var i=1; i<n; i++)
        {
            numbers.Add(i);
        }
        foreach(var number in numbers)
        {
            if(number % 2 != 0)
            {
                output = output + number.ToString() + " ";
            }
        }
        return output;
    }

    public static int DivisibleRangeCount(int n)
    {
        int count = 0;
        for(var i=1; i<=100; i++)
        {
            if(i%n == 0)
            {
                count++;
            }
        }
        return count;
    }

    public static int Factorial(int n)
    {
        int factorial = 1;
        while(n>0)
        {
            factorial = factorial * n;
            n--;
        }
        return factorial;
    }

    public static int FindMaximum(string commaSeparatedNumbers)
    {
        var list = commaSeparatedNumbers.Split(",").ToList();
        var listOfNumbers = new List<int>();

        foreach(var num in list)
        {
            listOfNumbers.Add((int)Convert.ToInt64(num));
        }
        var maxNumInList = listOfNumbers.Max();
        return maxNumInList;
    }
}
