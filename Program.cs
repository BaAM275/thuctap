using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace net1
{

    internal class Program
    {
        static void ShowHeaders(HttpResponseHeaders headers){
            Console.WriteLine("cac header");
            foreach(var header in headers){
                Console.WriteLine($"{header.Key} : {header.Value}");
            }
        }

        public static async Task<string> GetWebContent(string url){
            using var httpClient = new HttpClient(); 
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

            ShowHeaders(httpResponseMessage.Headers);

            string html = await httpResponseMessage.Content.ReadAsStringAsync();
            return html;
        }
        static async Task Main(string[] args)
        {

           using var httpClient = new HttpClient();

           var httpMessageResponse = new HttpRequestMessage();

           httpMessageResponse.Method = HttpMethod.Post;
           httpMessageResponse.RequestUri = new Uri("https://postman-echo.com/post");
           httpMessageResponse.Headers.Add("User-Agnet","Mozilla/5.0"); 

           var parameters = new List<KeyValuePair<string,string>>();
            parameters.Add(new KeyValuePair<string, string>("key1", "value1"));
            parameters.Add(new KeyValuePair<string, string>("key2", "value3"));
            parameters.Add(new KeyValuePair<string, string>("key3", "value2"));

            string data = @"{
                ""key3"":"" giatri"",
                ""key4"":""giatri3""
                }";

            Console.WriteLine(data);


            var content = new StringContent(data, Encoding.UTF8, "application/json");
            httpMessageResponse.Content = content;

            var httpResponseMessage = await httpClient.SendAsync(httpMessageResponse);

            var html = await httpResponseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(html);
            
          
        }
    }
}
