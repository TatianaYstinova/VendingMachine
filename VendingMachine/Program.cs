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
            vendingMachine.BuyDrink(latte);
            
            break;
        case 2:
            Drink cappuccino = new Drink("Капучино", 120, 40, 10, 150);
            
            vendingMachine.BuyDrink(cappuccino);
            break;
        case 3:
            Drink tea = new Drink("Чай черный", 100, 0, 0, 50);
            vendingMachine.BuyDrink(tea);
            break;
        case 0:
            Console.WriteLine("Выход из программы");
            break;
    }


} while (choice != 0);




