using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenBoxLibrary;
using Newtonsoft.Json;
using OpenBoxLibrary.Models;



namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new UrlReader();

            string regular = test.ReadUrl("http://www.ows.newegg.com/Products.egg/N82E16834312826/ProductDetails");
            string openBox = test.ReadUrl("http://www.ows.newegg.com/Products.egg/N82E16834312826R/ProductDetails");
            var tmp = JsonConvert.DeserializeObject<NeweggItem>(regular);
            var opentmp = JsonConvert.DeserializeObject<NeweggItem>(openBox);
           Console.Write("Test");
        }
    }
}
