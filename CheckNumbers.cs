
public class CheckNumbers
{

    public static Boolean CheckNumbersFunction(string numbersToCheck)
    {
        string[] arrayToCheck = numbersToCheck.Split(',');

        foreach (string item in arrayToCheck)
        {
            if (Int32.Parse(item) < 0)
            {
                Console.WriteLine("Please do not use negative numbers");
                Environment.Exit(0);
                return true;
            }

        }
        return false;
    }
}