using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewComponentsSample.Models;

namespace ViewComponentsSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var indexViewModel = new IndexViewModel
            {
                Sections = new List<PageSection>
                {
                    new PageSection
                    {
                        Title = "Books",
                        SectionItems = new List<SectionItem>
                        {
                            new SectionItem { Text = "ASP.NET Core in Action" },
                            new SectionItem { Text = "Node.js in Action"}
                        }
                    },
                    new PageSection
                    {
                        Title = "Services",
                        SectionItems = new List<SectionItem>
                        {
                            new SectionItem { Text = "ASP.NET Core Development"},
                            new SectionItem { Text = "Node.js Development"},
                            new SectionItem { Text = "Kubernetes"}
                        }
                    }
                }
            };
            return View(indexViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}