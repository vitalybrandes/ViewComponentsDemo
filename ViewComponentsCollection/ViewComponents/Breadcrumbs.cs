using Microsoft.AspNetCore.Mvc;
namespace RazorPages.ViewComponents
{
    public class BreadcrumbsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var myRoute = Url.RouteUrl(RouteData.Values);

            List<string> items = new List<string>();

            string[] words = myRoute.Split('/',StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                items.Add(word);
   
            }
            return await Task.FromResult((IViewComponentResult)View(items));
        }
    }
}