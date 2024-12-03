namespace MyNamespace;

public class ShowItemsCommand : IInterface
{
    private ShoppingList shoppingList;

    public ShowItemsCommand(ShoppingList shoppingList)
    {
        this.shoppingList = shoppingList;
    }

    public void Execute()
    {
        shoppingList.ShowItems();
    }
    public  string GetInfo()
    {
        string ShowItems = "Показати список покупок";
        return ShowItems;
    }
}