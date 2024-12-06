namespace MyNamespace;

class DeleteItemCommand : IInterface
{
    public async void Execute()
    {
        
        Console.WriteLine("Введіть назву продукту який хочете видалити:");
       string str_id = Console.ReadLine();
       int id = int.Parse(str_id);
       ShoppingList.DeleteItem(id);


    }
    public string GetInfo()
    {
        string DeleteItem = "Видалити  id з списока покупок";
        return DeleteItem;
    }
        
}