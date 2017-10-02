using Autos4Sale.Data.Models.Abstracts;

namespace Autos4Sale.Data.Models
{
    public class Image : DataModel
    {
        public string ImageUrl { get; set; }

        public virtual User Author { get; set; }

        public virtual CarOffer CarOffer { get; set; }
    }
}
