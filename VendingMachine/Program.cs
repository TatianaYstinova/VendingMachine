using SaleOfCoffee;
VendingMachine vendingMachine = new VendingMachine();
Console.WriteLine("Выберите номер товара");
Console.WriteLine("1 - Латте");
Console.WriteLine("2 - Капучино");
Console.WriteLine("3 - Чай черный");
int choice;
do
{
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Drink latte = new Drink("Латте", 100, 50, 10, 123);
            vendingMachine.DisplayPrice(latte);
            vendingMachine.BuyDrink(latte);
            
            break;
        case 2:
            Drink cappuccino = new Drink("Капучино", 120, 40, 10, 150);
            vendingMachine.DisplayPrice(cappuccino);
            vendingMachine.BuyDrink(cappuccino);
            break;
        case 3:
            Drink tea = new Drink("Чай черный", 100, 0, 0, 50);
            vendingMachine.DisplayPrice(tea);
            vendingMachine.BuyDrink(tea);
            break;
        case 0:
            Console.WriteLine("Выход из программы");
            break;
    }


} while (choice != 0);


NumberOfCoins.Add(1, 10);
NumberOfCoins.Add(2, 50);
NumberOfCoins.Add(5, 20);
NumberOfCoins.Add(10, 50);
NumberOfCoins.Add(50, 20);
NumberOfCoins.Add(100, 50);

