
// Add services to the container.


// Configure the HTTP request pipeline.
namespace csharp_boolflix.Models
{
    public class MediaInfo
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public bool IsNew { get; set; }
        public List<Actor> Cast { get; set; } = new List<Actor>();
        public List<Genre> Generes { get; set; } = new List<Genre>();
        public List<Feature> Features { get; set; } = new List<Feature>(); 

        //1 a 1 su media content (film)
        public int? FilmId { get; set; }
        public Film? Film { get; set; }

        //1 a 1 su media content (serie)
        public int? TVSerieId { get; set; }
        public TVSerie? TVSerie { get; set; }


    }
}


