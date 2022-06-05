using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Models
{
    public class AdvisorWithJobModel
    {
        public int AdvisorId { get; set; }
        public string AdvisorNameSurname { get; set; }
        public string AdvisorMail { get; set; }
        public string UserName  { get; set; }
        public string AdvisorPassword { get; set; }
        public string AdvisorPhone { get; set; }
        public string AdvisorAbout { get; set; }
        public DateTime AdvisorDateOfBirth { get; set; }
        public string AdvisorImg { get; set; }
        public int SuccessRate { get; set; }
        public bool IsSuitable { get; set; }
        public bool IsApproved { get; set; }
        public string ReturnUrl { get; set; }


        public int JobId { get; set; }
        public string JobName { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
