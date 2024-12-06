using System.Text;
using Newtonsoft.Json.Linq;



namespace MyNamespace
{

    public class DataRecive
    {
        static public async Task Get()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://localhost:5038/ShoppingList";
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
            string url = "http://localhost:5038/ShoppingList";



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

        static public async Task Delete(string json, int id)
        {
            string url = $"http://localhost:5038/ShoppingList/{id}";
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                try
                {
                    HttpRequestMessage request = new HttpRequestMessage()
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(url),
                        Content = content
                    };
                    HttpResponseMessage response = await client.SendAsync(request);
                    
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Об'єкт успішно видалено.");
                    }
                    
                    else
                    {
                        Console.WriteLine($"Помилка: {response.StatusCode}");
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Деталі: {responseBody}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            }
            
        }
    }
}