
// Add services to the container.


// Configure the HTTP request pipeline.
namespace csharp_boolflix.Models
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<MediaInfo> MediaInfos { get; set; }

    }
}



