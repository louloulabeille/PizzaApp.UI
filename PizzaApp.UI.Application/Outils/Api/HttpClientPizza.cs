using Newtonsoft.Json;
using PizzaApp.UI.Application.ModelDTO;
using PizzaApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.UI.Application.Outils.Api
{
    public class HttpClientPizza : BaseHttpClientPizza
    {
        /*
        protected override const string HttpMethod = "GET";
        protected override const string baseAdresse = @"http://localhost:5065/";
        protected override const string url = @"api/v1/pizza";
        */

        public HttpClientPizza() : base()
        {
            _httpMethod = "GET";
            _baseAdresse = @"http://localhost:5065/";
            _url = @"api/v1/pizza";
            Init();
        }

        public async Task<IEnumerable<PizzaDTO>> ReadApiJson()
        {
            var response = await this.GetHttpResponse();
            List<PizzaDTO> pizzas = new List<PizzaDTO>();

            /*JsonSerializerOptions options = new JsonSerializerOptions()
            {
                AllowTrailingCommas = true,
                PropertyNameCaseInsensitive = true,
                ReadCommentHandling = JsonCommentHandling.Skip,
            };
            var pizzas = await response.Content.ReadFromJsonAsync<IEnumerable<PizzaDTO>>(options);*/
            string json = await response.Content.ReadAsStringAsync();
            
            List<PizzaDTO>? jsonPizza = JsonConvert.DeserializeObject<List<PizzaDTO>>(json);
            if (jsonPizza != null)
            {
                pizzas.AddRange(jsonPizza);
            }

            return pizzas;
        }
    }
}
