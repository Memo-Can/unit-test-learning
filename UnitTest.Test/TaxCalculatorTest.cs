using UnitTest.App;

namespace UnitTest.Test;

public class TaxCalculatorTest
{
    private TaxCalculator taxCalculator { get; set; }

    public TaxCalculatorTest()
    {
        taxCalculator = new TaxCalculator();
    }

    [Theory]
    [InlineData(10, 10, 11)]
    [InlineData(50, 10, 55)]
    public void Add_SimpleValues_ReturnTotalResult(float price, float rate, float expectedResult)
    {
        var actualResult = taxCalculator.AddRate(price, rate);

        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [InlineData(0, 5, 0)]
    [InlineData(6, 0, 0)]
    public void Add_ZeroValues_ReturnZeroResult(float price, float rate, float expectedResult)
    {
        var actualResult = taxCalculator.AddRate(price, rate);

        Assert.Equal(expectedResult, actualResult);
    }
}
