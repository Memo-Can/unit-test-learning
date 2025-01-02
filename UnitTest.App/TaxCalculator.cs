namespace UnitTest.App;

public class TaxCalculator
{
    public float AddRate(float price, float rate)
    {
        if(price < 1 || rate<1)
            return 0;

        return price+((price * rate)/100);
    }
}
