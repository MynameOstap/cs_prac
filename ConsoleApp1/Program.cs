// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace MyNamespace
{
  
        
  
    

    class Program
    {

        
        static public async Task Get()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://localhost:3000/shop";
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); 
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);
                
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            
            }
     
        }

        static public async Task Post()
        {
            string url = "http://localhost:3000/shop";

            var data = new
            {
                Name = "John Doe",
                Age = 30,
                Email = "john.doe@example.com"
            };
            string json = JsonSerializer.Serialize(data);
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                client.Timeout = TimeSpan.FromSeconds(5);
                try
                {
                    var response = await client.PostAsync(url, content);
                    Console.WriteLine(response.StatusCode);
                }
                catch (TaskCanceledException e)
                {
                    Console.WriteLine("Timeout");
                    
                }
                

            
            }
            
        }
        static public async Task Main(string[] args)
        {
            await Post();
        }
        
        
       
        static void Main_(string[] args)

        {
            ShoppingList shoppingList = new ShoppingList();
            List<IInterface> command = new List<IInterface>
            {
                new AddItemCommand(shoppingList),
                new DeleteItemCommand(shoppingList),
                new ShowItemsCommand(shoppingList),
                new ShowTotalQuantityCommand(shoppingList)

            };
            new Menu(command).Execute();

            
        }
    }

    
}

