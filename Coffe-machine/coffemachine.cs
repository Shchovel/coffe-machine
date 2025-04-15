using System.Text.Json;

namespace Coffe_machine;

public class Coffemachine
{
    List<Drink> items = new();
    List<Ingradient> sorbs = new();

    public void AddIngradient()
    {
        var newItem = new Ingradient();

        var sorb = new Ingradient();

        Console.Write("Enter product Name: ");
        sorb.Name = Console.ReadLine();
        Console.Write("Enter product Weight: ");
        sorb.Weight = Console.ReadLine();

        sorbs.Add(sorb);
    }
    public void SaveToFile()
    {
        string jsonToSave = JsonSerializer.Serialize(items);
        Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json", jsonToSave);
    }
    public void LoadFromFile()
    {
        string jsonToLoad = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json");
        items = JsonSerializer.Deserialize<List<Drink>>(jsonToLoad);
    }
    public void AddDrink()
    {
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
    }
    public void ShowAllProducts()
    {
        foreach (var i in items)
        {
            Console.WriteLine("------- Drink ---------");
            Console.WriteLine($"Name: {i.Name}");
            Console.WriteLine($"Size: {i.Size}");
            Console.WriteLine($"Price: {i.Price}");
            Console.WriteLine($"RadiationLevel: {i.RadiationLevel}");
            Console.WriteLine($"Topings: {i.Topings}");
        }
    }
    public void Delete()
    {
        for (int i = 0; i < items.Count; ++i)
            Console.WriteLine($"[{i}] Drink: " + items[i].Name);

        Console.Write("Enter number to delete: ");
        int numToDelete = Convert.ToInt32(Console.ReadLine());

        if (numToDelete < 0 || numToDelete >= items.Count)
        {
            Console.WriteLine("Number out of range!");
            return;
        }

        items.RemoveAt(numToDelete);
        Console.WriteLine("Drink deleted successfully!");
    }
    public void FindDrinkById()
    {
        for (int i = 0; i < items.Count; ++i)
            Console.WriteLine($"[{i}] Product: " + items[i].Name);

        Console.Write("Enter number to show: ");
        int numToShow = Convert.ToInt32(Console.ReadLine());

        if (numToShow < 0 || numToShow >= items.Count)
        {
            Console.WriteLine("Number out of range!");
            return;
        }
        var itemToShow = items[numToShow];

        itemToShow.Show();
    }
}
