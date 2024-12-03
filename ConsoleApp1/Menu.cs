namespace MyNamespace;

class Menu 
{
    private List<IInterface> options;
    public Menu(List<IInterface> options)
    {
        this.options = options;
    }

    public void Execute()
    {
        while (true)
        {
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i+1} - {options[i].GetInfo()} ");
                    
            }
            Console.WriteLine("Щоб закрити програму введіть q");
            Console.Write(">>> ");

            string num_s = Console.ReadLine();
            if (!int.TryParse(num_s, out int result))
            {
                break;
            }
            int num = int.Parse(num_s);
            options[num-1].Execute();
                
            // Print all options with index
            // Get index from console
            // Execute choosen option
        }
    }
}