using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Shared.Models
{
    public class Content : BaseModel
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public string Url { get; set; }

        public Seo Seo { get; set; }
    }
}
