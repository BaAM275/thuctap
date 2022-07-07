using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace net1
{
    internal class Program
    {
        public static async Task<string> GetWebContent(string url){
            using var httpClient = new HttpClient(); 
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

            string html = await httpResponseMessage.Content.ReadAsStringAsync();
            return html;
        }
        static void Main(string[] args)
        {
           var url = "https://www.google.com/search?rlz=1C1JZAP_viVN944VN945&sxsrf=ALiCzsZPsbDjIsScjPw_IKz4_7rC_JV0Ow:1657160666629&q=thu+uy%C3%AAn&spell=1&sa=X&ved=2ahUKEwiBnPfG3OX4AhWCmlYBHdPOCKsQBSgAegQIChA-&biw=960&bih=968&dpr=1";
           var task = GetWebContent(url);
           task.Wait();
           var html = task.Result;
           Console.WriteLine(html);
           File.WriteAllText("html",html);
        }
    }
}
