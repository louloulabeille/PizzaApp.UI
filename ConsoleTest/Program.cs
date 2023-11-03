﻿using Newtonsoft.Json;
using PizzaApp.UI.Application.ModelDTO;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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


/*HttpClient client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:5065/");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
string json = JsonConvert.SerializeObject(new PizzaDTO());
StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

HttpResponseMessage response = await client.PutAsync(new Uri(client.BaseAddress.ToString() + "api/v1/Pizza"), httpContent);
*/



