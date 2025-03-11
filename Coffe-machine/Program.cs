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
Console.WriteLine("\t1. Add water");
Console.WriteLine("\t2. Add coffe");
Console.WriteLine("\t3. Add sugar");
Console.WriteLine("\t4. Add milk");
Console.WriteLine("\t5. show statistik");
Console.WriteLine("\t6. take cash");

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