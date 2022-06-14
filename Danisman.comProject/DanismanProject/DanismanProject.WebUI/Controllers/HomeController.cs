using DanismanProject.Business.Abstract;
using DanismanProject.Core;
using DanismanProject.Entity;
using DanismanProject.WebUI.EmailServices;
using DanismanProject.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Controllers
{
    public class HomeController : Controller
    {
       
        private IJobService _jobService;
        private IContactMessageService _contactMessageService;
        private IAdvisorService _advisorService;

        public HomeController(IJobService jobService, IAdvisorService advisorService, IContactMessageService contactMessageService)
        {
            _jobService = jobService;
            _advisorService = advisorService;
            _contactMessageService = contactMessageService;
        }
        public IActionResult Index()
        {
            return View(_jobService.GetAll()) ;
        }    

        public IActionResult AdvisorPage(string advisorname)
        {
            var entity = _advisorService.GetAdvisorDetail(advisorname);                
            return View(entity);

        }

        public IActionResult JobDetail(string jobName)
        {
            ViewBag.Advisors = _advisorService.GetAdvisorByCategory(jobName);
            return View(_jobService.GetJobDetail(jobName));
        }
        public IActionResult HelpContact()
        {
            return View();
        }
         
        [HttpPost]
        public IActionResult HelpContact(ContactMessage contactMessage)
        {
            if (ModelState.IsValid)
            {
                _contactMessageService.Create(contactMessage);
                TempData["Message"] = JobbManager.CreateMessage("Mesaj Gönderme", "Mesaj gönderme işlemi başarılı:) ", "success");
                return View();
            }
            else
            {
                TempData["Message"] = JobbManager.CreateMessage("Mesaj Gönderme", "Mesaj gönderme işlemi başarısız!", "danger");
                return View();
            }


        }











    }
}
