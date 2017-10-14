using Autos4Sale.Data.Models.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace Autos4Sale.Data.Models
{
    public class Image : DataModel
    {
        [MaxLength(550)]
        public string ImageUrl { get; set; }

        public virtual User Author { get; set; }

        public virtual CarOffer CarOffer { get; set; }
    }
}
