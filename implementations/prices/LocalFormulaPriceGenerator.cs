using System.Collections.Generic;

class LocalFormulaPriceGenerator : IPriceGenerator<IMenu>
{
    public Dictionary<IMenu, double> getPrices()
    {
        Dictionary<IMenu, double> prices = new Dictionary<IMenu, double>();
        prices[new Menu(DishType.Plate, DrinkSize.Medium, DessertType.Normal)] = 18;
        prices[new Menu(DishType.Plate, DrinkSize.Medium, DessertType.Normal, true)] = 18;
        prices[new Menu(DishType.Plate, DrinkSize.Large, DessertType.Special)] = 21;
        prices[new Menu(DishType.Sandwitch, DrinkSize.Medium, DessertType.Normal)] = 13;
        prices[new Menu(DishType.Sandwitch, DrinkSize.Large, DessertType.Special)] = 16;
        return prices;
    }
}