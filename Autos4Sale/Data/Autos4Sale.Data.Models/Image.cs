namespace Autos4Sale.Data.Models
{
    public class Image
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public virtual User User { get; set; }

        public virtual CarOffer CarOffer { get; set; }
    }
}
