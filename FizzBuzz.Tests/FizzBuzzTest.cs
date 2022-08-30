namespace FizzBuzz.Tests;

public class FizzBuzzTest
{
    FizzBuzz fizzBuzz = new FizzBuzz();

    [Fact]
    public void Number_1_Should_Say_1()
    {
        // Arrange
        var expectedResult = "1";

        // Act
        var actualResult = fizzBuzz.Say(1);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Number_2_Should_Say_2()
    {
        // Arrange
        var expectedResult = "2";

        // Act
        var actualResult = fizzBuzz.Say(2);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Number_3_Should_Say_Fizz()
    {
        // Arrange
        var expectedResult = "Fizz";

        // Act
        var actualResult = fizzBuzz.Say(3);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Number_4_Should_Say_4()
    {
        // Arrange
        var expectedResult = "4";

        // Act
        var actualResult = fizzBuzz.Say(4);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}