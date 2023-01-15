using Microsoft.AspNetCore.Mvc;
namespace RazorPages.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}