using System.Collections.Generic;

class LocalDishTypePriceGenerator : IPriceGenerator<DishType>
{
    public Dictionary<DishType, double> getPrices()
    {
        Dictionary<DishType, double> prices = new Dictionary<DishType, double>();
        prices[DishType.Plate] = 15;
        prices[DishType.Sandwitch] = 10;
        return prices;
    }
}