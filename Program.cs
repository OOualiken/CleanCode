using System;

namespace cleancode
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu(DishType.Sandwitch, DrinkSize.Medium, DessertType.Special, true);
            IBillCaculation bc = new LocalBillCaculation(
                new LocalDishTypePriceGenerator(),
                new LocalDrinkSizePriceGenerator(),
                new LocalDessertTypePriceGenerator(),
                new LocalFormulaPriceGenerator()
            );
            Console.WriteLine(bc.getTotal(m));
        }
    }
}
