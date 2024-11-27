namespace MyWebStory.Models
{
	public class IndexGallery
	{
		public required string Header { get; set; }
		public required string Description { get; set; }
		public IEnumerable<Spotlight> Gallery { get; set; } = new HashSet<Spotlight>();
	}
}
