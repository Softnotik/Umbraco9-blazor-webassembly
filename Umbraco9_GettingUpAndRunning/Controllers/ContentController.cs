using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.UmbracoContext;
using Umbraco.Cms;
using Umbraco;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Models;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Shared.Models;

namespace Umbraco9_GettingUpAndRunning.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ContentController : UmbracoApiController
    {
        private readonly IContentService contentService;

        public ContentController(IContentService contentService)
        {
            this.contentService = contentService;
        }

        [HttpGet]
        public ActionResult<Root> GetRoot(string lang = "")
        {
            var response = contentService.GetRootContent()
                .FirstOrDefault(c => c.PublishedState == PublishedState.Published && (c.PublishedCultures.Any(c => c == lang) || c.PublishedCultures.Count() == 0));

            var seo = new Seo()
            {
                Description = response.GetValue<string>("description", null, null, true)
            };

            return new Root
            {
                Title = response.PublishName,
                Seo = seo,
                Created = response.CreateDate
            };
        }

        [HttpGet]
        public ActionResult<Root> Get(string lang)
        {
            var response = contentService.GetRootContent()
                .FirstOrDefault(c => c.PublishedState == PublishedState.Published && (c.PublishedCultures.Any(c => c == lang) || c.PublishedCultures.Count() == 0));

            var seo = new Seo()
            {
                Description = response.GetValue<string>("description", null, null, true)
            };

            return new Root
            {
                Title = response.PublishName,
                Seo = seo,
                Created = response.CreateDate
            };
        }
    }
}
