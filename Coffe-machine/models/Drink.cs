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

public class Drink
{
    public string Name { get; set; }
    public int Size { get; set; }
    public double Price { get; set; }
    public int RadiationLevel { get; set; }
    public string Topings { get; set; }
    public void Show()
    {
        Console.WriteLine("------- Drink ---------");
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Size: {this.Size}");
        Console.WriteLine($"Price: {this.Price}");
        Console.WriteLine($"RadiationLevel: {this.RadiationLevel}");
        Console.WriteLine($"Topings: {this.Topings}");
    }


}
