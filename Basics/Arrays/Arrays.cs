namespace Basics.Arrays;

public class Arrays
{
    public static string ReverseString(string name)
    {
        string reverseString = string.Empty;
        var arrOfName = name.ToArray();
        Array.Reverse(arrOfName);
        foreach(var item in arrOfName)
        {
            reverseString = reverseString + item.ToString();
        }
        return reverseString;
    }
}