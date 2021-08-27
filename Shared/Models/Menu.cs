using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Shared.Services;

namespace WebApplication1.Shared.Models
{
    public class Menu : BaseModel
    {
        private IContentService contentService;

        public Menu(IContentService contentService)
        {
            this.contentService = contentService;
        }

        public string Title { get; set; }

        public string Url { get; set; }

        public string ParentId { get; set; }

        public ICollection<Menu> Children
        {
            get
            {
                return null; // contentService.
            }
        }
    }
}
