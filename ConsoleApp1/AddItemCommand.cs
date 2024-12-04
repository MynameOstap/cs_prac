namespace MyNamespace;

class AddItemCommand : IInterface
{
    // private ShoppingList ShoppingList;
    //
    // public  AddItemCommand(ShoppingList shoppingList)
    // {
    //     this.ShoppingList = shoppingList;
    // }

    public async void Execute()
    {
        Console.WriteLine("Введіть назву продукту:");
        string name = Console.ReadLine();
        Console.WriteLine("Введіть кількість:");
        int quality = 0;
        bool isQualityValid = false;
        while (!isQualityValid)
        {
            isQualityValid = int.TryParse(Console.ReadLine(), out quality);
            if (!isQualityValid) 
            {
                Console.WriteLine("Введіть дійсне число");
               
            }
            if (quality <= 0)
            {
                isQualityValid = false;
                Console.WriteLine("Введіть дійсне число");
            }
                
                
        }
           
           
        Console.WriteLine("Введіть ціну:");
        decimal price = 0;
        bool isPriceValid = false;
        while (!isPriceValid)
        {
            isPriceValid = decimal.TryParse(Console.ReadLine(), out price);
            if (!isPriceValid) 
            {
                Console.WriteLine("Введіть дійсне число");
               
            }

            if (price <= 0)
            {
                isPriceValid = false;
                Console.WriteLine("Введіть дійсне число");
            }
                
        }
        ShoppingList.AddItem(name,quality,price);
        Console.WriteLine("Продукт успішно додано до списку!");
    }

    public string GetInfo()
    {
        string AddItem = "Добавити продукт в список покупок";
        return AddItem;
    }
}