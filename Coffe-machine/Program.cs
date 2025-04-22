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

using Coffe_machine;
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

Coffemachine coffemachine = new(); 




while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            coffemachine.AddIngradient();
            break;

        case 2:
            coffemachine.SaveToFile();
            break;
        case 3:
            coffemachine.LoadFromFile();
            break;

        case 7:
            coffemachine.AddDrink();
            break;
        case 4:
            coffemachine.ShowAllProducts();
            break;
        case 8:
            coffemachine.Delete();
            break;

        case 9:
            coffemachine.FindDrinkById();
            break;
    }
}
    


Console.WriteLine("- User");
Console.WriteLine("\t1. Order");
