// See https://aka.ms/new-console-template for more information

namespace MyNamespace
{
    public class Item
    {
        public string Name { get; set; }
        public int Quality { get; set; }
        public decimal Price { get; set; }

        public Item(string name,int quality,decimal price)
        {
            Name = name;
            Quality = quality;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}: {Quality} шт  {Price} грн.";
        }
        
    }

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
   

    class Program
    {
        static void Main(string[] args)
        {
            ShoppingList shoppingList = new ShoppingList();

            // Додавання товарів
            shoppingList.AddItem("Яблука", 5, 12.5m);
            shoppingList.AddItem("Хліб", 2, 20m);
            shoppingList.AddItem("Молоко", 1, 30m);

            // Показ списку
            shoppingList.ShowItems();

            // Видалення товару
            shoppingList.RemoveItem("Хліб");

            // Показ списку після видалення
            shoppingList.ShowItems();

            // Загальна кількість товарів
            Console.WriteLine($"Загальна кількість товарів: {shoppingList.GetTotalQuantity()}");

            // Спроба видалити товар, якого немає
            shoppingList.RemoveItem("Шоколад");
        }
    }

    
}

