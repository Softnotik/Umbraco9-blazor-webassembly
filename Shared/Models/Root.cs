using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Shared.Models
{
    public class Root : BaseModel
    {
        public string Title { get; set; }
        public Seo Seo { get; set; }
    }
}
