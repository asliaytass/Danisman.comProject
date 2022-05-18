using DanismanProject.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IJobService _jobService;
        public HomeController(IJobService jobService)
        {
            _jobService = jobService;
        }


        public IActionResult Index()
        {
            return View(_jobService.GetAll()) ;
        }     
    }
}
