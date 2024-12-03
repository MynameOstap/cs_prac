namespace MyNamespace;

public class ShowTotalQuantityCommand : IInterface
{
    private ShoppingList shoppingList;

    public ShowTotalQuantityCommand(ShoppingList shoppingList)
    {
        this.shoppingList = shoppingList;
    }

    public void Execute()
    {
        Console.WriteLine($"Загальна кількість товарів: {shoppingList.GetTotalQuantity()}");
    }
    public string GetInfo()
    {
        string ShowTotalQuantity = "Показати кількість покупок";
        return ShowTotalQuantity;
    }
}