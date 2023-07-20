﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace FetsyMvcUI.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.GetAll();
            return View(values);
        }
    }
}
