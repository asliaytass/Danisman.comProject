using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Entity
{
    public class Subcategory
    { //Kategori dışında alt kategorilerimizde bulunmaktadır. Bu yüzden altkategori entitimizi de ekliyoruz.
        public int SubcategoryId { get; set; }
        public string SubcategoryName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<SubcategoryAdvisor> SubcategoryAdvisors { get; set; }


    }
}
