using System.Collections.Generic;

class LocalDrinkSizePriceGenerator : IPriceGenerator<DrinkSize>
{
    public Dictionary<DrinkSize, double> getPrices()
    {
        Dictionary<DrinkSize, double> prices = new Dictionary<DrinkSize, double>();
        prices[DrinkSize.Small] = 2;
        prices[DrinkSize.Medium] = 3;
        prices[DrinkSize.Large] = 4;
        return prices;
    }
}