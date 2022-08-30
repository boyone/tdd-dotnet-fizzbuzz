namespace FizzBuzz;
public class FizzBuzz
{
    public string Say(int number)
    {
        string value = "";

        if (number % 3 == 0)
        {
            value += "Fizz";
        }
        if (number % 5 == 0)
        {
            value += "Buzz";
        }
        if (value == "") {
            value = number.ToString();
        }
        return value;
    }
}


