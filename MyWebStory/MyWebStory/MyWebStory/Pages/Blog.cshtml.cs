using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebStory.Models;
using MyWebStory.Services;

namespace MyWebStory.Pages
{
    public class BlogModel : PageModel
    {
        private readonly IBlogService service;

        //Dependency Inversion: Bağımlılıkların dışarıda bırakılması anlamına gelir, bu sayade daha önceden program.cs üzeründe tanımlanmış kütüphaneler bağlanır.
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
