using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebStory.Models;
using MyWebStory.Services;

namespace MyWebStory.Pages
{
    public class BlogModel : PageModel
    {
        private readonly IBlogService service;

        //Dependency Inversion: Baðýmlýlýklarýn dýþarýda býrakýlmasý anlamýna gelir, bu sayade daha önceden program.cs üzeründe tanýmlanmýþ kütüphaneler baðlanýr.
		public BlogModel(IBlogService service)
		{
			this.service = service;
		}
        public IEnumerable<Post> Posts { get; set; } = new HashSet<Post>();
		public void OnGet()
        {
            Posts = service.GetPosts();
        }
    }
}
