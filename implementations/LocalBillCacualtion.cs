using System;
using System.Collections.Generic;

class LocalBillCaculation : IBillCaculation
{
    private IPriceGenerator<DishType> DishTypePriceGenerator;
    private IPriceGenerator<DrinkSize> DrinkSizePriceGenerator;
    private IPriceGenerator<DessertType> DessertTypePriceGenerator;
    private IPriceGenerator<IMenu> FormulaPriceGenerator;

    public LocalBillCaculation(IPriceGenerator<DishType> DishTypePriceGenerator, 
                               IPriceGenerator<DrinkSize> DrinkSizePriceGenerator, 
                               IPriceGenerator<DessertType> DessertTypePriceGenerator,
                               IPriceGenerator<IMenu> FormulaPriceGenerator) {
        this.DishTypePriceGenerator = DishTypePriceGenerator;
        this.DrinkSizePriceGenerator = DrinkSizePriceGenerator;
        this.DessertTypePriceGenerator = DessertTypePriceGenerator;
        this.FormulaPriceGenerator = FormulaPriceGenerator;
    }

    public double getTotal(IMenu menu)
    {
        try {
            return this.FormulaPriceGenerator.getPrices()[menu];
        } catch {
            // In case of the formula is not found
            double total = this.DishTypePriceGenerator.getPrices()[menu.DishType];
            total += this.DrinkSizePriceGenerator.getPrices()[menu.DrinkSize];
            total += this.DessertTypePriceGenerator.getPrices()[menu.DessertType];
            return total + (menu.HasCoffee ? 1 : 0);
        }
    }

}