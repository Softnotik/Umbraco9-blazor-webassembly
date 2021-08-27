using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Shared.Models
{
    public class Seo
    {
        private string _Twitter_Image;
        private string _OG_Image;
        private string _OG_Url;

        public string Description { get; set; }

        public string Twitter_Site { get; set; }
        public string Twitter_Image_Alt { get; set; }

        public string Twitter_Card { get; set; }

        public string Twitter_Title { get; set; }
        public string Twitter_Description { get; set; }


        public string Twitter_Image {
            get
            {
                return _Twitter_Image;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) _Twitter_Image = new Uri(value).ToString();
            }
        }

        public string OG_Site_Name { get; set; }
        public string OG_Title { get; set; }
        public string OG_Description { get; set; }
        public string OG_Image {
            get
            {
                return _OG_Image;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) _OG_Image = new Uri(value).ToString();
            }
        }
        public string OG_Url
        {
            get
            {
                return _OG_Url;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) _OG_Url = new Uri(value).ToString();
            }
        }
    }
}
