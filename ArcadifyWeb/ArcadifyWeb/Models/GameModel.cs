namespace ArcadifyWeb.Models
{
    public class GameModel
    {
        public int? Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public string Short_Description { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Platform { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public string Developer { get; set; } = string.Empty;
        public string Release_Date { get; set; } = string.Empty;
    }
}

