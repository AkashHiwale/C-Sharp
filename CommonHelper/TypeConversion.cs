namespace CommonHelper;

public class TypeConversion
{
    public static int StringToInt(string input)
    {
        int result = (int)Convert.ToInt64(input);
        return result;
    }

    public static bool StringToBool(string input)
    {
        bool result = Convert.ToBoolean(input);
        return result;
    }
}