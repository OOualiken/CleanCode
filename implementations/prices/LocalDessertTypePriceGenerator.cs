using System.Collections.Generic;

class LocalDessertTypePriceGenerator : IPriceGenerator<DessertType>
{
    public Dictionary<DessertType, double> getPrices()
    {
        Dictionary<DessertType, double> prices = new Dictionary<DessertType, double>();
        prices[DessertType.Normal] = 2;
        prices[DessertType.Special] = 4;
        return prices;
    }
}