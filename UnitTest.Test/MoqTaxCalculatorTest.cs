using System;
using Moq;
using UnitTest.App;

namespace UnitTest.Test;

public class MoqTaxCalculatorTest
{
    private readonly TaxCalculator _taxCalculator;
    private readonly Mock<ITaxCalculatorService> _mock;

    public MoqTaxCalculatorTest()
    {
        _mock = new Mock<ITaxCalculatorService>();
        _taxCalculator = new TaxCalculator(_mock.Object);
    }

    [Theory]
    [InlineData(10, 10, 11)]
    [InlineData(50, 10, 55)]
    public void Add_SimpleValues_ReturnTotalResult(float price, float rate,float expectedResult)
    {
        //Just run only the specific method that prevents initializing all objects
        _mock.Setup(x=>x.AddRate(price,rate)).Returns(expectedResult);

        var result = _taxCalculator.AddRate(price,rate);

        Assert.Equal(expectedResult, result);;

        _mock.Verify(x=>x.AddRate(price,rate), Times.Once);
    }

    [Theory]
    [InlineData(-1, 0)]
    public void Add_ZeroValues_ReturnTotalResult(float price, float rate)
    {
        //The exception message should be the same as method validation
        _mock.Setup(x=>x.AddRate(price,rate)).Throws(new Exception("Values can not be lower than zero."));

        var exception=Assert.Throws<Exception>(()=> _taxCalculator.AddRate(price, rate));

        Assert.Equal("Values can not be lower than zero.", exception.Message);;
    }
}