using Newtonsoft.Json;
using PizzaApp.UI.Application.ModelDTO;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var socketHandler = new SocketsHttpHandler()
{
    PooledConnectionLifetime = TimeSpan.FromSeconds(5),
};

HttpClient client = new HttpClient(socketHandler,false);
client.BaseAddress = new Uri("http://localhost:5065/");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

HttpResponseMessage response = await client.GetAsync(new Uri(client.BaseAddress.ToString()+"api/v1/pizza"));
try
{
    response.EnsureSuccessStatusCode();
    JsonSerializerOptions options = new JsonSerializerOptions() {
        AllowTrailingCommas = true,
        PropertyNameCaseInsensitive = true,
        ReadCommentHandling = JsonCommentHandling.Skip,
    };
    var pizzas = await response.Content.ReadFromJsonAsync<IEnumerable<PizzaDTO>>(options);

    if (pizzas != null)
    {
        foreach (PizzaDTO pizza in pizzas)
        {
            Console.WriteLine(pizza.Nom);
        }
    }
    Console.ReadLine();
}
catch (HttpRequestException hTRex)
{
    Console.WriteLine(hTRex.Message);
    response.Dispose();
}


/*HttpClient client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:5065/");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
string json = JsonConvert.SerializeObject(new PizzaDTO());
StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

HttpResponseMessage response = await client.PutAsync(new Uri(client.BaseAddress.ToString() + "api/v1/Pizza"), httpContent);
*/



