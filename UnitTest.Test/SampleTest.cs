using System.Net.Mail;
using UnitTest.App;

namespace UnitTest.Test;

public class SampleTest
{
    [Fact]
    public void AddRateTest()
    {
        //Arrange
        float price = 100;
        float rate = 20;
        var taxedPrice = new TaxCalculatorService();

        //Act
        var result = taxedPrice.AddRate(price, rate);

        //Assert
        Assert.Equal<float>(120, result);
    }

    [Fact]
    public void ContainsTest()
    {
        Assert.Contains("Hello", "Hello World!");
    }

    [Fact]
    public void ContainsWithEnumurableTest()
    {
        var cars = new List<string> { "mercedes", "toyota", "opel" };

        Assert.Contains(cars, car => car == "mercedes");
    }

    [Fact]
    public void TrueTest()
    {
        Assert.True(0 != 1);
    }

    [Fact]
    public void MatchsTest()
    {
        var mailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        Assert.Matches(mailPattern, "test@test.com");
    }

    [Fact]
    public void StartsWithTest()
    {
        Assert.StartsWith("Hello", "Hello World!");
    }

    [Fact]
    public void EndsWithTest()
    {
        Assert.EndsWith("!", "Hello World!");
    }

    [Fact]
    public void EmptyTest()
    {
        var games = new List<string>();

        Assert.Empty(games);
    }

    [Fact]
    public void NotEmptyTest()
    {
        var games = new List<string> { "red alert", "doom", "gta" };

        Assert.NotEmpty(games);
    }

    [Fact]
    public void InRangeTest()
    {
        Assert.InRange(60, 0, 100);
    }

    [Fact]
    public void SingleTest()
    {
        Assert.Single(new List<string> { "test" });
    }

    [Fact]
    public void IsTypeTest()
    {
        Assert.IsType<bool>(true);
    }

    [Fact]
    public void IsAssignableFormTest()
    {
        Assert.IsAssignableFrom<IDisposable>(new SmtpClient());
    }

    [Fact]
    public void NullTest()
    {
        Assert.Null(null);
    }

    [Fact]
    public void EqualTest()
    {
        Assert.Equal(1,1);
    }
}