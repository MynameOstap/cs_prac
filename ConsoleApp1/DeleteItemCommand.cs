namespace MyNamespace;

class DeleteItemCommand : IInterface
{
    private ShoppingList ShoppingList;

    public DeleteItemCommand(ShoppingList shoppingList)
    {
        this.ShoppingList = shoppingList;
    }

    public void Execute()
    {
        Console.WriteLine("Введіть назву продукту який хочете видалити:");
        string name = Console.ReadLine();
        ShoppingList.RemoveItem(name);
            
            
    }
    public string GetInfo()
    {
        string DeleteItem = "Видалити  продукт з списока покупок";
        return DeleteItem;
    }
        
}