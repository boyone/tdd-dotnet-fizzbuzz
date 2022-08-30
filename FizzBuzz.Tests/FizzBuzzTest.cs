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

    [Fact]
    public void Number_5_Should_Say_Buzz()
    {
        // Arrange
        var expectedResult = "Buzz";

        // Act
        var actualResult = fizzBuzz.Say(5);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Number_6_Should_Say_Fizz()
    {
        // Arrange
        var expectedResult = "Fizz";

        // Act
        var actualResult = fizzBuzz.Say(6);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Number_7_Should_Say_7()
    {
        // Arrange
        var expectedResult = "7";

        // Act
        var actualResult = fizzBuzz.Say(7);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Number_9_Should_Say_Fizz()
    {
        // Arrange
        var expectedResult = "Fizz";

        // Act
        var actualResult = fizzBuzz.Say(9);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Number_10_Should_Say_Buzz()
    {
        // Arrange
        var expectedResult = "Buzz";

        // Act
        var actualResult = fizzBuzz.Say(10);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Number_12_Should_Say_Fizz()
    {
        // Arrange
        var expectedResult = "Fizz";

        // Act
        var actualResult = fizzBuzz.Say(12);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Number_15_Should_Say_FizzBuzz()
    {
        // Arrange
        var expectedResult = "FizzBuzz";

        // Act
        var actualResult = fizzBuzz.Say(15);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void Number_45_Should_Say_FizzBuzz()
    {
        // Arrange
        var expectedResult = "FizzBuzz";

        // Act
        var actualResult = fizzBuzz.Say(45);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}