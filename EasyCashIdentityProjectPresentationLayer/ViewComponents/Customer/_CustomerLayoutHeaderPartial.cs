﻿using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProjectPresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
