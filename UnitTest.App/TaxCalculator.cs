using System;

namespace UnitTest.App;

public class TaxCalculator : ITaxCalculatorService
{
    private readonly ITaxCalculatorService _taxCalculatorService;
    
    public TaxCalculator(ITaxCalculatorService taxCalculatorService)
    {
        _taxCalculatorService = taxCalculatorService;
    }

    public float AddRate(float price, float rate)
    {
        return _taxCalculatorService.AddRate(price, rate);
    }
}
