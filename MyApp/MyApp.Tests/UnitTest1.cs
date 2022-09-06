namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void leap_year_if_divisible_by_four()
    {
        // Arrange
        var year = new LeapYear(40);

        // Act
        Boolean result = year.isLeapYear();

        // Assert
        Assert.True(result);

    }

    [Fact]
    public void leap_year_if_divisible_by_400()
    {
        // Arrange
        var year = new LeapYear(800);

        // Act
        Boolean result = year.isLeapYear();

        // Assert
        Assert.True(result);

    }

    [Fact]
    public void not_leap_year_if_divisible_by_4_and_100()
    {
        // Arrange
        var year = new LeapYear(200);

        // Act
        Boolean result = year.isLeapYear();

        // Assert
        Assert.False(result);

    }

}