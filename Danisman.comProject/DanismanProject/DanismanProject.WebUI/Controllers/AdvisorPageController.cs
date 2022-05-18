using DanismanProject.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Controllers
{
    public class AdvisorPageController : Controller
    {
        private IAdvisorService _advisorService;
        public AdvisorPageController(IAdvisorService advisorService)
        {
            _advisorService = advisorService;
        }
        public IActionResult Index()
        {
            //ViewBag.SubCategoris=...... subcategory servisi hazırladıktan sonra çağır
            return View(_advisorService.GetAll());
        }
    }
}
