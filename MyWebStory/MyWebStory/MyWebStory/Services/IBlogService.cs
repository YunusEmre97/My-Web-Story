using MyWebStory.Models;

namespace MyWebStory.Services
{
	public interface IBlogService
	{
		IEnumerable<Post> GetPosts();
	}
	public class BlogService : IBlogService
	{
		public IEnumerable<Post> GetPosts()
		{
			var posts = new List<Post>();
			for (int i = 1; i <= 5; i++)
			{
				posts.Add(new Post
				{
					Id = i,
					Header = $"Post Header {i}",
					Body = $"{i}. Benim Blog Sayfam.",
					Image = $"https://picsum.photos/800/450?random={i}"
				});
			}
			return posts;
		}
	}
}
