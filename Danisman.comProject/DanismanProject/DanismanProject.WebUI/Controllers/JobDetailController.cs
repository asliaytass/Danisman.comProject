using DanismanProject.Business.Abstract;
using DanismanProject.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Controllers
{
    public class JobDetailController : Controller
    {
        
        private IAdvisorService _advisorService;
        public JobDetailController( IAdvisorService advisorService)
        {
            _advisorService = advisorService;
        }
        public IActionResult Index()
        {
            ViewBag.Advisors = _advisorService.GetAll();
            return View(_advisorService.GetAll()) ; //Bu şekilde dene çünkü tablolar arası ilişki var.
        }
      
    }
}
