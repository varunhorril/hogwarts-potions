namespace HogwartsPotions.Web.Models
{
    public class PotionReview
    {
        public int Id { get; set; }
        public int PotionId { get; set; }
        public string Title { get; set; }
        public string Review { get; set; }
    }
}