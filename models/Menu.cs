using System;

class Menu: IMenu {
    public DishType DishType { get; set; }
    public DrinkSize DrinkSize { get; set; }
    public DessertType DessertType { get; set; }

    public bool HasCoffee { get; set; }

    public Menu(DishType DishType, DrinkSize DrinkSize, DessertType DessertType = DessertType.Normal, bool HasCoffee = false) {
      this.DishType = DishType;
      this.DrinkSize = DrinkSize;
      this.DessertType = DessertType;
      this.HasCoffee = HasCoffee;
    }

    public override int GetHashCode() {
      return this.DishType.GetHashCode() + this.DrinkSize.GetHashCode() + this.DessertType.GetHashCode() + this.HasCoffee.GetHashCode();
    }

    public override bool Equals(Object obj) {
      if ((obj == null) || ! this.GetType().Equals(obj.GetType())) {
         return false;
      }
      Menu m = (Menu)obj;
      return  m.DishType == this.DishType && m.DrinkSize == this.DrinkSize && m.DessertType == this.DessertType && m.HasCoffee == this.HasCoffee;
   }

   public override string ToString() {
      return "{DishType: " + this.DishType + ", DrinkSize: " + this.DrinkSize + ", DessertType: " + this.DessertType + ", HasCoffee: " + this.HasCoffee + "}";
   }
}