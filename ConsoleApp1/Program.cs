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
                new DeleteItemCommand(),
                new ShowItemsCommand()
                // new ShowTotalQuantityCommand(shoppingList)

            };
            new Menu(command).Execute();

            
        }
    }

    
}

