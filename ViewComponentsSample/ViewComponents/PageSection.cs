using Microsoft.AspNetCore.Mvc;

namespace ViewComponentsSample.ViewComponents
{
    public class PageSection : ViewComponent
    {
        public IViewComponentResult Invoke(Models.PageSection section)
        {
            return View("~/Views/Shared/Components/PageSection/Default.cshtml", section);
        }
    }
}