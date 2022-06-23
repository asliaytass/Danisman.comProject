using DanismanProject.Business.Abstract;
using DanismanProject.Business.Concrete;
using DanismanProject.Entity;
using DanismanProject.WebUI.Identity;
using DanismanProject.WebUI.Models;
using DanismanProject.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private IAdvisorService _advisorService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        private IContactMessageService _contactMessageService;
        private IJobService _jobService;

        public AdminController(IAdvisorService advisorService, RoleManager<IdentityRole> roleManager, UserManager<User> userManager, IContactMessageService contactMessageService, IJobService jobService)
        {
            _advisorService = advisorService;
            _roleManager = roleManager;
            _userManager = userManager;
            _contactMessageService = contactMessageService;
            _jobService = jobService;
        }

        public IActionResult JobList()
        {
            return View(_jobService.GetAll());
        }
        public IActionResult JobEdit(int jobId)
        {
            var job = _jobService.GetById(jobId);
            return View(job);
        }
        [HttpPost]
        public IActionResult JobEdit(Job job)
        {

            _jobService.Update(job);
            return RedirectToAction("JobList","Admin");
        }
        [HttpPost]
        public IActionResult JobDelete(int jobId)
        {
            var entity = _jobService.GetById(jobId);
            _jobService.Delete(entity);
            return RedirectToAction("JobList","Admin");
        }
        public IActionResult JobCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult JobCreate(IFormFile file,Job job)
        {
            if (file != null)
            {
                var url = JobbManager.MakeUrl(job.JobName);
                job.JobImg = JobbManager.UploadImage(file, url);
                _jobService.Create(job);
                TempData["Message"] = JobbManager.CreateMessage("Yeni Kategori Kaydı", "Kategori ekleme işlemi başarıyla tamamlanmıştır.", "success");
                return RedirectToAction("JobList","Admin");
            }
            TempData["Message"] = JobbManager.CreateMessage("Yeni Kategori Kaydı", "Kategori ekleme işlemi başarılı değil.", "danger");
            return View(job);
        }


        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }

        public IActionResult UserCreate()
        {
            var roles = _roleManager.Roles.Select(i => i.Name);
            ViewBag.Roles = roles;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserCreate(UserDetailsModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email,
                    EmailConfirmed = model.EmailConfirmed
                };
                var result = await _userManager.CreateAsync(user, "Qwe123.");
                if (result.Succeeded)
                {
                    selectedRoles = selectedRoles ?? new string[] { };
                    await _userManager.AddToRolesAsync(user, selectedRoles);
                    return Redirect("~/admin/user/list");
                }
                var roles = _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles;
                return View(model);


            }
            var roles2 = _roleManager.Roles.Select(i => i.Name);
            ViewBag.Roles = roles2;
            return View(model);
        }

        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles = _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles;
                return View(new UserDetailsModel()
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SelectedRoles = selectedRoles
                });
            }
            return Redirect("~/admin/user/list");
        }

        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailsModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.UserName = model.UserName;
                    user.Email = model.Email;
                    user.EmailConfirmed = model.EmailConfirmed;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles ?? new string[] { };
                        await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles).ToArray<string>()); //selectedRoles.Except(userRoles) kullanıcının hali hazırda bulunan rolleri haricinde kalan rolleri kaydedecek
                        await _userManager.RemoveFromRolesAsync(user, selectedRoles.Except(selectedRoles).ToArray<string>()); //selectedRoles.Except(selectedRoles).ToArray<string>()   kullanıcının hali hazırda bulunan rolleri haricinde kalan rolleri silecek
                        return Redirect("~/admin/user/list");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    var roles = _roleManager.Roles.Select(i => i.Name);
                    ViewBag.Roles = roles;
                    return View(model);

                }
                ModelState.AddModelError("", "Böyle bir kullanıcı yok!");
                var roles2 = _roleManager.Roles.Select(i => i.Name);
                ViewBag.Roles = roles2;
                return View(model);
            }
            ModelState.AddModelError("", "Böyle bir kullanıcı yok!");
            var roles3 = _roleManager.Roles.Select(i => i.Name);
            ViewBag.Roles = roles3;
            return View(model);

        }

         [HttpPost]
        public async Task<IActionResult> UserDelete(string UserId)
        {
            var user = await _userManager.FindByIdAsync(UserId);
          
                await _userManager.DeleteAsync(user);
            return Redirect("~/admin/user/list");
            
        }

        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }

        public IActionResult RoleCreate()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            //rolleri oluşturacak kodlar yazılacak
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(
                    new IdentityRole(model.Name)
                    );
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            var members = new List<User>();
            var nonMembers = new List<User>();

            foreach (var user in _userManager.Users)
            {
                //if (await _userManager.IsInRoleAsync(user,role.Name))
                //{
                //    members.Add(user);
                //}
                //else
                //{
                //    nonMembers.Add(user);
                //}

                var list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }


                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }


            }
            return Redirect("/admin/role/" + model.RoleId);
        }

        [HttpPost]
        public async Task<IActionResult> RoleDelete(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role!=null)
            {
                var result = await _roleManager.DeleteAsync(role);
                return Redirect("~/admin/role/list");
            }
            else
            {
                return Redirect("~/admin/role/list");
            }
            

        }


       

        public IActionResult AdvisorList()
        {
            return View(_advisorService.GetAll());
        }
       

        public IActionResult AdvisorDetail(int id)
        {
            //var entity = _advisorService.GetAdvisorDetail(advisorname);
            //return View(entity);
            var entity= _advisorService.GetByIdWithJobs(id);
            return View(entity);           
        }

        public IActionResult AdvisorDelete(int id)
        {            
                var entity = _advisorService.GetById(id);
                _advisorService.Delete(entity);
            //TempData["Message"] = JobManager.CreateMessage("", "İşlem başarısız oldu, lütfen daha sonra tekrar deneyiniz!", "danger");
            return RedirectToAction("AdvisorList","Admin");     
        }

        public IActionResult AdvisorEdit( int id)
        {            
            return View(_advisorService.GetById(id));
        }

        [HttpPost]
        public IActionResult AdvisorEdit(Advisor advisor)
        {
            //var advisor = new Advisor()
            //{
            //    AdvisorId=model.AdvisorId,
            //    SuccessRate=model.SuccessRate,
            //    IsApproved=model.IsApproved
            //};
            _advisorService.Update(advisor);
            return RedirectToAction("AdvisorList");
        }

        

        public IActionResult MessageBox()
        {
            return View(_contactMessageService.GetAll());
        }

      



    }
}
