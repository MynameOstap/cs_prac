namespace MyNamespace;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;


public class ShoppingList
{
    // private List<Item> items;
    //
    // public ShoppingList()
    // {
    //     items = new List<Item>();
    // }

    public static async void AddItem(string name, int quality, decimal price)
    {
        // items.Add(new Item(name,quality,price));
        var data = new Item
        {
            Name = name,
            Quality = quality,
            Price = price
        };
        string json = JsonSerializer.Serialize(data);
        await DataRecive.Post(json);
        Console.WriteLine($"Ви додали ноаий елемент: {name}: {quality} шт  {price} грн. ");
    }

    public static async void DeleteItem(int id)
    {
        var data = id;
        string json = JsonSerializer.Serialize(data);
        await DataRecive.Delete(json,id);
        
    }


//     public void RemoveItem(string name)
//     {
//         var item = items.Find(i => i.Name == name);
//
//         if (item == null)
//         {
//             Console.WriteLine("Обєкт не знайдено");
//         }
//
//         items.Remove(item);
//         Console.WriteLine($"товер {name} видалено зі списку");
//
//             
//     }
//
    public static async void ShowItems()
    {
        await DataRecive.Get();
    }
}
//
//     public int  GetTotalQuantity()
//     {
//         int total = 0;
//         foreach (var item in items)
//         {
//             total += item.Quality;
//         }
//
//         return total;
//     }
//         
// }