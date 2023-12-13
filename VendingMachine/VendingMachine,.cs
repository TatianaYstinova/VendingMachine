using System;
using System.Collections;
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

        public  void InfoVendingMachine()
        {
            CashBalance = 0;
            WaterResidue = 0;
            LeftoverCoffee = 0;
            MilkResidue = 0; ;
            SugarResidue = 0;

            Console.WriteLine("Баланс автомата:{cashBalance}");
            Console.WriteLine("Колличество воды в автомате:{waterResidue}");
            Console.WriteLine("Колличество кофе в автомате:{leftoverCoffee}");
            Console.WriteLine("Колличество молока в автомате:{milkResidue}");
            Console.WriteLine("Колличество сахара в автомате:{sugarResidue}");
        }
        public void ToppingUpMachine(int amount, int literOfWater, int grains, int literOfMilk,int kilogramOfSugar)
        {
            CashBalance += amount;
            WaterResidue += literOfWater;
            LeftoverCoffee += grains;
            MilkResidue += literOfMilk;
            SugarResidue += kilogramOfSugar;
        }
       
        public void AddBalance(int amount)
        {
            Console.WriteLine($"Вы внесли {amount}");
            Earnings += amount;

        }
        public double сalculateChange(double productPrice, double cashAmount)
        {
            if (cashAmount < productPrice)
            {
                throw new ArgumentException("Недостаточно наличных для оплаты продукта.");
            }

            Dictionary<int, int> numberOfCoins = new Dictionary<int, int>();
            double change = cashAmount - productPrice;
            double result = change;

            if (change > 0)
            {
                int oneRuble = 0;
                int twoRubles = 0;
                int fiveRubles = 0;

                while (change >= 5)
                {
                    change -= 5;
                    fiveRubles++;
                }

                while (change >= 2)
                {
                    change -= 2;
                    twoRubles++;
                }

                while (change >= 1)
                {
                    change -= 1;
                    oneRuble++;
                }
                numberOfCoins.Add(1, oneRuble);
                numberOfCoins.Add(2, twoRubles);
                numberOfCoins.Add(5, fiveRubles);

                this.NumberOfCoins[1] = this.NumberOfCoins[1] - numberOfCoins[1];
                this.NumberOfCoins[2] = this.NumberOfCoins[2] - numberOfCoins[2];
                this.NumberOfCoins[3] = this.NumberOfCoins[3] - numberOfCoins[3];
            }

            return result;
        }
        public void BuyDrink(Drink drink)
        {
            Console.WriteLine("Вы выбрали напиток: " + drink.Name +" "+drink.Price);
            Console.WriteLine("Введите количество сахара для напитка: ");
            int sugarAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите способ оплаты (1 - наличными, 2 - картой): ");
            int paymentMethod = Convert.ToInt32(Console.ReadLine());

            if (paymentMethod == 1)
            {
                Console.WriteLine("Внесите сумму в купюроприемник");
                double cashAmount = Convert.ToDouble(Console.ReadLine());
                try
                {
                    double change = сalculateChange(drink.Price, cashAmount);
                    Console.WriteLine("Ваша сдача: " + change);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(" Oшибка оплаты");
                }

            }
            else if (paymentMethod == 2)
            {
                Console.WriteLine("Оплата прошла");
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












