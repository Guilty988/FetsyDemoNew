using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace FetsyMvcUI.ViewComponents.Default
{
    public class _Feature : ViewComponent 
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            //var values = featureManager.GetAll();
            // ViewBag.image1 = featureManager.get

            // 18.video dakika 6 
            return View();
        }
    }
}
