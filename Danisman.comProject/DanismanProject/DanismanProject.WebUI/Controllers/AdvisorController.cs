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
        private UserManager<User> _userManager;




        public AdvisorController(IAdvisorService advisorService, IJobService jobService, UserManager<User> userManager)
        {
            _advisorService = advisorService;
            _jobService = jobService;
            _userManager = userManager;

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
            var userId = _userManager.GetUserId(User);
            var job = Request.Form.Keys.Where(x => x.Contains("JobId")).ToList();
            if (job != null && job.Count > 0)
            {
                foreach (var item in job)
                {
                    string name = item.Split('|')[0].ToString();

                    advisor.JobId = _jobService.GetJobDetail(name).JobId;
                    advisor.AdvisorId = userId;
                }
            }
            _advisorService.CreateAdvisor(advisor);
            return RedirectToAction("Index", "Home");


        }


    }
}
