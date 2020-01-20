using System.Collections.Generic;
interface IPriceGenerator<T> {
    Dictionary<T, double> getPrices();
}