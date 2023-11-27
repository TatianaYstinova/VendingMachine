using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleOfCoffee
{
    public class Drink
    {
        public string Name { get; set; }
        public int AmountOfWaterConsumed { get; set; }
        public int AmountOfMilkConsumed { get; set; }
        public int AmountOfCoffeeBeansConsumed { get; set; }    
        public double Price { get; set; }
        public Drink(string name, int amountOfWaterConsumed, int amountOfMilkConsumed, int amountOfCoffeeBeansConsumed, double price)
        {
            Name = name;
            AmountOfWaterConsumed = amountOfWaterConsumed;
            AmountOfMilkConsumed = amountOfMilkConsumed;
            AmountOfCoffeeBeansConsumed = amountOfCoffeeBeansConsumed;
            Price = price;
        }
    }
}
