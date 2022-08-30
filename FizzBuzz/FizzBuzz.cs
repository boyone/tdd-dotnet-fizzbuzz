namespace FizzBuzz;
public class FizzBuzz
{
    public string Say(int number)
    {
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        if (number % 5 == 0)
        {
            return "Buzz";
        }
        return number.ToString();
    }
}


