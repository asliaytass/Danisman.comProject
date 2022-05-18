using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Entity
{
    public class SubcategoryAdvisor
    {
        //alt kategori ve danışmanlar arasında çoka çok bir ilişki olduğu için ayrı bir tablo oluşturuldu.

        public int AdvisorId { get; set; }
        public Advisor Advisor { get; set; }

        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }


    }
}
