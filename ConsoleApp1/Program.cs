// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
                    
                    JArray data = JArray.Parse(responseBody);

                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            
            }
     
        }

        static public async Task Post(string json)
        {
            string url = "http://localhost:3000/shop";

            
            
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
      
        
        
       
        static public void  Main(string[] args)

        {
            Ping pingSender = new Ping();
            try
            {
                PingReply reply = pingSender.Send("localhost");
                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine($"Server work, deley {reply.RoundtripTime}");
                }
                else
                {
                    Console.WriteLine("Server dont work");
                }
            }
            catch (PingException )
            {
                Console.WriteLine("Dont connect server");
             
            }
            
            List<IInterface> command = new List<IInterface>
            {
                new AddItemCommand(),
                // new DeleteItemCommand(shoppingList),
                new ShowItemsCommand()
                // new ShowTotalQuantityCommand(shoppingList)

            };
            new Menu(command).Execute();

            
        }
    }

    
}

