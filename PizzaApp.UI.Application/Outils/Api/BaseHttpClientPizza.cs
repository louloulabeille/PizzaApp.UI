using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.UI.Application.Outils.Api
{
    public abstract class BaseHttpClientPizza : IDisposable
    {
        protected readonly HttpClient _httpClient;
        protected string _baseAdresse = @"http://localhost:5065/";
        protected string _url = @"api/v1/pizza";

        protected BaseHttpClientPizza()
        {
            _httpClient = new HttpClient();
            Init();
        }

        protected virtual void Init()
        {
            _httpClient.BaseAddress = new Uri(_baseAdresse);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public virtual async Task<HttpResponseMessage> GetHttpResponse()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(new Uri(_httpClient.BaseAddress.ToString() + _url));
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException hTRex)
            {
                Console.WriteLine(hTRex.Message);
                Dispose();
            }
            return response;
        }


        /// <summary>
        /// methode Post httpClient pas testé
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> PostHttpResponse(HttpContent content)
        {
            HttpResponseMessage response = await _httpClient.PostAsync(new Uri(_httpClient.BaseAddress.ToString() + _url),content);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException hTRex)
            {
                Console.WriteLine(hTRex.Message);
                Dispose();
            }
            return response;
        }
            

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
