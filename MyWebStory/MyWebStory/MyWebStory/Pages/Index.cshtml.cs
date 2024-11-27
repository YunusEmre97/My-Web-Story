using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebStory.Models;
using MyWebStory.Services;

namespace MyWebStory.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ISpotlightService service;
        public IndexModel(ISpotlightService service)
        {
            this.service = service;
        }
        public IEnumerable<Spotlight> Spotlights { get; set; } = new HashSet<Spotlight>();
        public IndexGallery? Gallery { get; set; }
        public IEnumerable<AttributeItem> Attributes { get; set; } = new HashSet<AttributeItem>();
        public void OnGet()
        {
            Spotlights = service.GetSpotlightList();
            Gallery = service.GetGallery();
            Attributes = service.GetAttributes();
        }
    }
}
