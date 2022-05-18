using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImg{ get; set; }

        public List<Advisor> Advisors { get; set; }
        public List<Content> Contents { get; set; }
        public List<Subcategory> Subcategories { get; set; }
    }
}
