using DanismanProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanismanProject.WebUI.Models
{
    public class JobDetailModel
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobImg { get; set; }
        public List<Category> CategoryContents { get; set; }
        public List<Subcategory> SubcategoryNames { get; set; }
    }
}
