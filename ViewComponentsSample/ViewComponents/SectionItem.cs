using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewComponentsSample.Models;

namespace ViewComponentsSample.ViewComponents
{
    public class SectionItem : ViewComponent
    {
        public IViewComponentResult Invoke(string text)
        {
            return View("~/Views/Shared/Components/SectionItem/Default.cshtml", text);
        }
    }
}