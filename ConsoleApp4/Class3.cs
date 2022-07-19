using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScrapySharp.Extensions;
using System.Web;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using ConsoleApp4;


namespace Crawl_TGDD
{
    class Program
    {
        public static void Main(string[] args)
        {
            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };
            var paralelOption = new ParallelOptions { MaxDegreeOfParallelism = 50 };
            List<ketoan> Listproduct = new List<ketoan>();
            Parallel.For(1, 1000, paralelOption, (paging, loopState) =>
            {
                Console.WriteLine(paging.ToString());
                HtmlDocument document = htmlWeb.Load($"https://sanketoan.vn/danh-sach-ung-vien?page={paging}");

                var products = document.DocumentNode.CssSelect("div.content_box_employee div.item_employee_new");
                if (products == null)
                    loopState.Break();



                foreach (var product in products)
                {

                    var productObject = new ketoan();//khoi tao object product
                    var name = product.CssSelect("div.item_employee_intro h3").FirstOrDefault().InnerText;//gia tri name
                    productObject.name = name;
                    var salary = product.CssSelect("p.mgb5.clRed.js_salary").FirstOrDefault().InnerText;//gia tri name
                    productObject.salary = salary;

                    var address = product.CssSelect("p.mgb5.clBlack.cutTitle.areaEmployeeWork.js_provice_district").FirstOrDefault().InnerText;// gia tri adress 
                    productObject.address = address;

                    var level = product.CssSelect("span.js_profile").FirstOrDefault().InnerText;
                    productObject.level = level;

                    var exp = product.CssSelect("p.mgb5.cutTitle.clGreen").FirstOrDefault().InnerText;
                    productObject.exp = exp;



                    var link = product.CssSelect("a").FirstOrDefault().GetAttributeValue("href");
                    productObject.url = link;

                    Listproduct.Add(productObject);

                }

            });
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Listproduct);
            string fileSPath = @"quangdeptria.txt";
            System.IO.File.WriteAllText(fileSPath, json);

        }

    }

}