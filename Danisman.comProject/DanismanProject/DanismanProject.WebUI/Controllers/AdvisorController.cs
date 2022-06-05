using DanismanProject.Business.Abstract;
using DanismanProject.Entity;
using DanismanProject.WebUI.EmailServices;
using DanismanProject.WebUI.Identity;
using DanismanProject.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Controllers
{
    public class AdvisorController : Controller
    {
        private IAdvisorService _advisorService;
        private IJobService _jobService;
        
      


        public AdvisorController(IAdvisorService advisorService, IJobService jobService)
        {
            _advisorService = advisorService;
            _jobService = jobService;
         
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdvisorMyAccount(string username)
        {
            return View();

        }
        public IActionResult AdvisorApplication()
        {
            ViewBag.Jobs = _jobService.GetAll();
            return View();
        }

    [HttpPost] 

    public IActionResult AdvisorApplication(Advisor advisor)
    {
        
        var job=Request.Form.Keys.Where(x => x.Contains("JobId")).ToList();
            if (job != null && job.Count > 0)
            {
                foreach (var item in job)
                {
                    string name = item.Split('|')[0].ToString();

                    advisor.JobId = _jobService.GetJobDetail(name).JobId;
                }
            } 
                 _advisorService.CreateAdvisor(advisor);
                 return RedirectToAction("Index","Home");

      
    } 
     

    }
}
