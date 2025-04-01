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

using System.Text.Json;

Console.WriteLine("-----CoffeMachine-----");

Console.WriteLine("\t Menu:");

Console.WriteLine("- Admin");
Console.WriteLine("\t1. Add ingredient");
Console.WriteLine("\t2. Save to file");
Console.WriteLine("\t3. Load from file");
Console.WriteLine("\t4. Show all products");

Console.WriteLine("\t5. show statistik");
Console.WriteLine("\t6. take cash");
Console.WriteLine("\t7. Add drink");

List<Drink> items = new();
List<Ingradient> sorbs = new();

while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            //var sorb = new Ingradient();

            //Console.Write("Enter product Name: ");
            //sorb.Name = Console.ReadLine();
            //Console.Write("Enter product Weight: ");
            //sorb.Weight = Console.ReadLine();
            break;

        case 2:
            string jsonToSave = JsonSerializer.Serialize(items);
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json", jsonToSave);
            break;
        case 3:
            string jsonToLoad = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json");
            items = JsonSerializer.Deserialize<List<Drink>>(jsonToLoad);
            break;

        case 7:
            var item = new Drink();

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

            items.Add(item);
            break;
        case 4:
            foreach (var i in items)
            {
                Console.WriteLine("------- Drink ---------");
                Console.WriteLine($"Name: {i.Name}");
                Console.WriteLine($"Size: {i.Size}");
                Console.WriteLine($"Price: {i.Price}");
                Console.WriteLine($"RadiationLevel: {i.RadiationLevel}");
                Console.WriteLine($"Topings: {i.Topings}");
            }
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