using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Entity
{
    public class Content
    {
       
        public int ContentId { get; set; }
        public string ContentName { get; set; }
        public string ContentImg { get; set; }
        public string ContentText { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
