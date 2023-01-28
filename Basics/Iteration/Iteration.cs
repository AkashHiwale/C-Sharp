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
}
