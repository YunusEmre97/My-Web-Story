using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebStory.Models;
using MyWebStory.Services;

namespace MyWebStory.Pages
{
    public class BlogModel : PageModel
    {
        private readonly IBlogService service;

        //Dependency Inversion: Ba��ml�l�klar�n d��ar�da b�rak�lmas� anlam�na gelir, bu sayade daha �nceden program.cs �zer�nde tan�mlanm�� k�t�phaneler ba�lan�r.
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
