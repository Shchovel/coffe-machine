/* 4. ------------------- Автомат гарячих напоїв.
Створити ієрархію класів для подання гарячих напоїв Автомату(кава, чай, капучіно та ін.)
Створити програму для роботи Автомату у  режимах адмін та користувач
У режимі адміна передбачити

    Завантаження автомату водою, кава, чай, цукор
    Вивід статистики наявності складових для приготування напоїв

    Зміна цін на напої

    Вилучення кешу
У режимі користувача передбачити
Замовлення напою(+ оплата)
*/

Console.WriteLine("-----CoffeMachine-----");

Console.WriteLine("\t Menu:");

Console.WriteLine("- Admin");
Console.WriteLine("\t1. Add ingredient");

Console.WriteLine("\t5. show statistik");
Console.WriteLine("\t6. take cash");
Console.WriteLine("\t7. Add drink");

Drink item = new();
Ingradient sorb = new();

while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter product Name: ");
            sorb.Name = Console.ReadLine();
            Console.Write("Enter product Weight: ");
            sorb.Weight = Console.ReadLine();
            break;
        case 7:
            Console.Write("Enter product Name: ");
            item.Name = Console.ReadLine();
            Console.Write("Enter product Size: ");
            item.Size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter product Price: ");
            item.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter product RadiationLevel: ");
            item.RadiationLevel = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter product Topings: ");
            item.Topings = Console.ReadLine();
            break;
        case 4:
            Console.WriteLine("------- Drink ---------");
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Size: {item.Size}");
            Console.WriteLine($"Price: {item.Price}");
            Console.WriteLine($"RadiationLevel: {item.RadiationLevel}");
            Console.WriteLine($"Topings: {item.Topings}");
            break;
    }
}

Console.WriteLine("- User");
Console.WriteLine("\t1. Order");


public class Drink
{
    public string Name { get; set; }
    public int Size { get; set; }
    public double Price { get; set; }
    public int RadiationLevel { get; set; }
    public string Topings { get; set; }
}

public class Ingradient
{
    public string Name { get; set; }
    public string Weight { get; set; }
   
}