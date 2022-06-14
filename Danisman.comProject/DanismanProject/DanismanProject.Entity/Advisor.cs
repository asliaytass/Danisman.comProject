using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Entity
{
    public class Advisor
    {
        
        public int AdvisorId { get; set; }
        public string AdvisorName { get; set; }
        public string AdvisorSurname { get; set; }      
        public string AdvisorMail { get; set; }       
        public string AdvisorPhone { get; set; }
        public string AdvisorAbout { get; set; }
        public DateTime AdvisorDateOfBirth { get; set; }
        public string AdvisorImg { get; set; }
        public int SuccessRate { get; set; }
        public bool IsSuitable { get; set; }
        public bool IsApproved { get; set; }
        public int Price { get; set; }





        public int JobId { get; set; }
        public Job Job { get; set; }

       




    }
}
