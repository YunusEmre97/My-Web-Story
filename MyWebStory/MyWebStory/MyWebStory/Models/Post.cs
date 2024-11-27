namespace MyWebStory.Models
{
	public class Post
	{
		public int Id { get; set; }
		public required string Header { get; set; }
		public required string Body { get; set; }
		public required string Image { get; set; }
	}
}
