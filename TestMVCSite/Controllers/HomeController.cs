using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceStack;
using TestMVCSite.Models;

namespace TestMVCSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly JsonServiceClient _jsonClient;

        public HomeController()
        {
            
            _jsonClient = new JsonServiceClient("https://covid-19-statistics.p.rapidapi.com");
            _jsonClient.Headers.Add("x-rapidapi-key", "76548c6ba4msh11ab1ec6e61ac7dp12e0c3jsn42e5fddc3ed5");
            _jsonClient.Headers.Add("x-rapidapi-host","covid-19-statistics.p.rapidapi.com");

        }
        
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
        public IActionResult CovidReport()
        {
            ViewData["Message"] = "COVID Report";

            var regionsResponse = _jsonClient.Get<RegionsResponse>( new Regions());

            var lst = (from d in regionsResponse.data
                                        select new SelectListItem
                                        {
                                            Value = d.iso.ToString(),
                                            Text = d.name.ToString(),
                                        }).OrderBy(x => x.Text).ToList();
            
            
            return View(lst);

        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
