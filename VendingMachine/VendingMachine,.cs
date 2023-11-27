using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleOfCoffee
{
    public class VendingMachine
    {
        public double CashBalance { get; set; }
        public Drink[] Drinks { get; set; }
        public int WaterResidue { get; set;}
        public int LeftoverCoffee { get; set; }
        public int MilkResidue { get; set; }
        public int SugarResidue { get;set; }
        public int Earnings { get;set; }
        Dictionary<int,int> NumberOfCoins { get; set; }

        public void AddBalance(int amount)
        {
            Console.WriteLine($"Вы внесли {amount}");
            Earnings += amount;

        }
        public double CalculateChange(double productPrice, double cashAmount)
        {
            Console.WriteLine("Вставьте деньги в купюроприемник");
            Dictionary<int, int> numberOfCoins = new Dictionary<int, int>();
            if (cashAmount < productPrice)
            {
                throw new ArgumentException("Недостаточно наличных для оплаты продукта.");
            }
            else if(cashAmount> productPrice)
            {
                double change = cashAmount - productPrice;
                int OneRuble = 0;
                int TwoRubles = 0;
                int FiveRubles = 0;


               while (change >= 1)
                {
                    change = change - 1;
                    OneRuble++;

                }

            }

           
            return change;
        }
        public void DisplayPrice(Drink drink)
        {
            Console.WriteLine($"Цена напитка" + " " + drink.Name + " " +" "+ drink.Price );
        }
        
        
        public void BuyDrink(Drink drink)
        {
            Console.WriteLine("Вы выбрали напиток: " + drink.Name);
            Console.WriteLine("Введите количество сахара для напитка: ");
            int sugarAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите способ оплаты (1 - наличными, 2 - картой): ");
            int paymentMethod = Convert.ToInt32(Console.ReadLine());

            if (paymentMethod == 1)
            {
                CalculateChange()
            }
            else if (paymentMethod == 2)
            {
            }
            else
            {
                Console.WriteLine("Некорректный способ оплаты");
                return;
            }
            Console.WriteLine("Спасибо за покупку!");
        }

    }
}












