namespace MyNamespace;

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

