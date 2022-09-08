namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void leap_year_if_divisible_by_four()
    {
        // Arrange
        var year = new LeapYear();

        // Act
        Boolean result = year.isLeapYear(40);

        // Assert
        Assert.False(result);

    }

    [Fact]
    public void leap_year_if_divisible_by_400()
    {
        // Arrange
        var year = new LeapYear();

        // Act
        Boolean result = year.isLeapYear(1600);

        // Assert
        Assert.True(result);

    }

    [Fact]
    public void not_leap_year_if_divisible_by_4_and_100()
    {
        // Arrange
        var year = new LeapYear();

        // Act
        Boolean result = year.isLeapYear(200);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void freshFadeTest()
    {
        var leapYear = new LeapYear();
        using var reader = new StringReader("mads\n");
        Console.SetIn(reader);
        using var writer = new StringWriter();
        Console.SetOut(writer);
        leapYear.takeInput();
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().BeEquivalentTo("Type a year Error: Year must be a postive integer Type a year");
    }
}