using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Models
{
    public class AdvisorEditModel
    {
        public int AdvisorId { get; set; }

        public int SuccessRate { get; set; }
        public bool IsApproved { get; set; }

    }
}
