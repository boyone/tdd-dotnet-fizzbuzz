namespace FizzBuzz.Tests;

public class FizzBuzzTest
{
    [Fact]
    public void Number_1_Should_Say_1()
    {
        // Arrange
        var expectedResult = "1";
        var fizzBuzz = new FizzBuzz();

        // Act
        var actualResult = fizzBuzz.Say(1);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}