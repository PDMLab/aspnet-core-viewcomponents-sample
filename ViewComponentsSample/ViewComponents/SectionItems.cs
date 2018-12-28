using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ViewComponentsSample.ViewComponents
{
    public class SectionItems : ViewComponent
    {
        public IViewComponentResult Invoke(List<Models.SectionItem> sectionItems)
        {
            return View("~/Views/Shared/Components/SectionItems/Default.cshtml", sectionItems);
        }
    }
}