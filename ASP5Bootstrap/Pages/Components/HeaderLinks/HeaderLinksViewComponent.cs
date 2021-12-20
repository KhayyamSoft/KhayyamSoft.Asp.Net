using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IVC_WebApp.Pages.Models;

namespace IVC_WebApp.Pages.Components
{
    public class HeaderLinksViewComponent : ViewComponent
    {
        public HeaderLinksViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync(List<HeaderLinkModel> headerLinks)
        {
            return await Task.FromResult((IViewComponentResult)View("HeaderLinks", headerLinks));
        }
    }
}
