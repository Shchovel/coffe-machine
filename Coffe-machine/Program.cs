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
Console.WriteLine("\t8. Delete");
Console.WriteLine("\t9. Find Drink by id");



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
            break;
        case 8:
            for (int i = 0; i < items.Count; ++i)
                Console.WriteLine($"[{i}] Drink: " + items[i].Name);

            Console.Write("Enter number to delete: ");
            int numToDelete = Convert.ToInt32(Console.ReadLine());

            if (numToDelete < 0 || numToDelete >= items.Count)
            {
                Console.WriteLine("Number out of range!");
                break;
            }

            items.RemoveAt(numToDelete);
            Console.WriteLine("Drink deleted successfully!");
            break;

        case 9:
            for (int i = 0; i < items.Count; ++i)
                Console.WriteLine($"[{i}] Product: " + items[i].Name);

            Console.Write("Enter number to show: ");
            int numToShow = Convert.ToInt32(Console.ReadLine());

            if (numToShow < 0 || numToShow >= items.Count)
            {
                Console.WriteLine("Number out of range!");
                break;
            }
            var itemToShow = items[numToShow];

            itemToShow.Show();
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

public class Ingradient
{
    public string Name { get; set; }
    public string Weight { get; set; }
   
}
