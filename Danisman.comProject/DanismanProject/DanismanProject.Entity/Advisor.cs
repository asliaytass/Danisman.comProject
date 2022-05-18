using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Entity
{
    public class Advisor
    {
        public int AdvisorId { get; set; }
        public string AdvisorNameSurname { get; set; }
        public int SuccessRate { get; set; }
        public bool IsSuitable { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }//Anasayfada tüm danışmanları gösteremeyiz onun için Ishome true olanlar görünecek

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int? JobId { get; set; }
        public Job Job { get; set; }

        public List<SubcategoryAdvisor> SubcategoryAdvisors { get; set; }
    }
}
