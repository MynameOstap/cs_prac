namespace MyNamespace;

public class ShoppingList
{
    private List<Item> items;

    public ShoppingList()
    {
        items = new List<Item>();
    }

    public void AddItem(string name, int quality, decimal price)
    {
        items.Add(new Item(name,quality,price));
        Console.WriteLine($"Ви додали ноаий елемент: {name}: {quality} шт  {price} грн. ");
    }

    public void RemoveItem(string name)
    {
        var item = items.Find(i => i.Name == name);

        if (item == null)
        {
            Console.WriteLine("Обєкт не знайдено");
        }

        items.Remove(item);
        Console.WriteLine($"товер {name} видалено зі списку");

            
    }

    public void ShowItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item.ToString());
                
        }
    }

    public int  GetTotalQuantity()
    {
        int total = 0;
        foreach (var item in items)
        {
            total += item.Quality;
        }

        return total;
    }
        
}