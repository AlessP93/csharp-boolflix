
// Add services to the container.


// Configure the HTTP request pipeline.
namespace csharp_boolflix.Models
{
    public class TVSerie : MediaContent
    {
        public int SeasonCount { get; set; }

        public MediaInfo MediaInfo { get; set; }

        public List<Episode> Episodes { get; set; }
    }
}


