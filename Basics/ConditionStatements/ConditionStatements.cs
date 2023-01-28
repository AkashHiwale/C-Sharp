namespace Basics.ConditionStatements;

public class ConditionStatements
{
    public static string TimesOfDay(int hour)
    {
        if (hour > 0 && hour < 12)
        {
            return "It's morning.";
        }
        else if (hour > 12 && hour < 18)
        {
            return "It's afternoon.";
        }
        else
        {
            return "It's evening.";
        }
    }

    public static string IsGoldCustomer(bool isGoldCustomer)
    {
        float price = (isGoldCustomer) ? 19.95f : 29.95f;
        return $"Customer price is: {price}.";
    }

    public static string WhichSeason(string season)
    {
        string output;
        switch (season)
        {
            case "summer":
                output =  "It's a summer season, It's good time to go to a beach.";
                break;
            case "winter":
                output =  "It's a winter season, It's best season to go to a trip.";
                break;
            case "rainy":
                output =  "It's a rainy sesaon. It's best time to get a tea and snake.";
                break;
            default:
                output = "Sorry, I don't understand this season.";
                break;
        }
        return output;
    }

    public static string IsNumberInRange(int number)
    {
        if (number >= 1 && number <= 10)
        {
            return $"Number {number} is in valid range.";
        }
        else
        {
            return "Invalid Input";
        }
    }

    public static string MaxNumber(int a, int b)
    {
        if (a > b)
        {
            return $"Number {a} is greater than {b}.";
        }
        else if (a < b)
        {
            return $"Number {b} is greater than {a}.";
        }
        else
        {
            return "Both the numbers are same.";
        }
    }

    public static string ImageOrientation(int height, int weight)
    {
        if (height > weight)
        {
            return "Image is Portrait";
        }
        else if (height < weight)
        {
            return "Image is Landscape";
        }
        else
        {
            return "Image is square";
        }
    }
}