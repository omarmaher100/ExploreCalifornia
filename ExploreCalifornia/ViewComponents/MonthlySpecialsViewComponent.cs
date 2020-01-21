using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.ViewComponents
{
  //  [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        private readonly BlogDataContext _dp;
        public MonthlySpecialsViewComponent(BlogDataContext dp)
        {
            this._dp = dp;
        }
        public IViewComponentResult Invoke()
        {
            var specials = _dp.MonthlySpecials.ToArray();
            return View(specials);
        }
    }
}
