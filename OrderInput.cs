
public class OrderInput
{

    public static string[] OrderInputFunction(string stringToOrder)
    {
        string[] numbersArray = stringToOrder.Split(',');



        for (int i = 1; i < numbersArray.Length - 1; i += 2)
        {
            int number1 = Int32.Parse(numbersArray[i]);
            int number2 = Int32.Parse(numbersArray[i + 1]);

            if (number1 > number2)
            {
                (numbersArray[i], numbersArray[i + 1]) = (numbersArray[i + 1], numbersArray[i]);
            }
        }

        return numbersArray;

    }

}