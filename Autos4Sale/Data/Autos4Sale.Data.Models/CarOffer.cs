using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos4Sale.Data.Models
{
    public class CarOffer
    {
        private ICollection<Image> image;

        public CarOffer()
        {
            this.image = new HashSet<Image>();
        }

        public int Id { get; set; }

        public virtual User User { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public DateTime DatePosted { get; set; }

        public virtual ICollection<Image> Image
        {
            get { return this.image; }
            set { image = value; }
        }
    }
}
