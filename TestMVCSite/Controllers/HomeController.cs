using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using TestMVCSite.Models;

namespace TestMVCSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public async Task<IActionResult> CovidReport()
        {
            ViewData["Message"] = "COVID Report";
            
            /*var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://covid-19-statistics.p.rapidapi.com/regions"),
                Headers =
                {
                    { "x-rapidapi-key", "SIGN-UP-FOR-KEY" },
                    { "x-rapidapi-host", "covid-19-statistics.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                return View(body);
            }*/
            
            var client = new RestClient("https://covid-19-statistics.p.rapidapi.com/regions");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "SIGN-UP-FOR-KEY");
            request.AddHeader("x-rapidapi-host", "covid-19-statistics.p.rapidapi.com");
            var response = client.Execute(request);
            
            return View(response);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
