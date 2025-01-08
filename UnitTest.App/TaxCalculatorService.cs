namespace UnitTest.App;

public class TaxCalculatorService : ITaxCalculatorService
{
    public float AddRate(float price, float rate)
    {
        if (price < 0 || rate < 0)
            throw new Exception("Values can not be lower than zero.");

        return price + ((price * rate) / 100);
    }
}
