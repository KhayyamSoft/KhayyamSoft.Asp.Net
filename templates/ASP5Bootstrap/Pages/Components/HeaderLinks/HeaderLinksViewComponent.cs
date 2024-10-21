using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IVC_WebApp.Pages.Components
{
    public class HeaderLinksViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(List<HeaderLinkModel> headerLinks)
        {
            return await Task.FromResult((IViewComponentResult)View("HeaderLinks", headerLinks));
        }
    }
}
