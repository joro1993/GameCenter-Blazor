namespace gamecenter.Shared.Models
{
    public class GamesGenres
    {
        public int GameId { get; set; }
        public int GenreId { get; set; }  
        public Game Game { get; set; }
        public Genre Genre { get; set; }            
    }
}