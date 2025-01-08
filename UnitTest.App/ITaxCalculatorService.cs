using System;

namespace UnitTest.App;

public interface ITaxCalculatorService
{
    public float AddRate(float price, float rate);
}
