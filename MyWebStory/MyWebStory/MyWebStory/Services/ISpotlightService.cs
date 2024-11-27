using MyWebStory.Models;

namespace MyWebStory.Services
{
	public interface ISpotlightService
	{
		IEnumerable<Spotlight> GetSpotlightList(int start = 1, int limit = 3);
		IndexGallery GetGallery();
		IEnumerable<AttributeItem> GetAttributes();
	}
	public class SpotlightService : ISpotlightService
	{
		public IEnumerable<AttributeItem> GetAttributes()
		{
			string[] icons = { "fa-gem", "solid fa-save", "solid fa-chart-bar" };
			var attributes = new List<AttributeItem>();
			for (int i = 0; i < 3; i++)
			{
				attributes.Add(new AttributeItem
				{
					Icon = icons[i],
					Header = $"Attribute Header {i + 1}",
					Description = $"{i + 1}. Benim Yetenek Sayfam."
				});
			}
			return attributes;
		}

		public IndexGallery GetGallery()
		{
			return new IndexGallery
			{
				Header = "My Portfolio",
				Description = "Benim Pörtfoy Sayfam",
				Gallery = GetSpotlightList(4, 12)
			};
		}

		public IEnumerable<Spotlight> GetSpotlightList(int start = 1, int limit = 3)
		{
			var spotlights = new List<Spotlight>();
			for (int i = start; i < start + limit; i++)
			{
				spotlights.Add(new Spotlight
				{
					Id = i,
					Header = $"Spotlight Header{i}",
					Body = $"{i}. Benim Blog Sayfam.",
					Image = $"https://picsum.photos/800/450?random={i}"
				});
			}
			return spotlights;
		}
	}
}
