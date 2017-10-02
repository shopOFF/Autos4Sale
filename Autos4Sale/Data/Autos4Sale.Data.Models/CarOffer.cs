using Autos4Sale.Data.Models.Abstracts;
using Autos4Sale.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Autos4Sale.Data.Models
{
    public class CarOffer : DataModel
    {
        private ICollection<Image> image;

        public CarOffer()
        {
            this.image = new HashSet<Image>();
        }

        public virtual User Author { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int YearManufacured { get; set; }

        public TransmissionType Transmission { get; set; }

        public EngineType Engine { get; set; }

        public CarCategoryType CarCategory { get; set; }

        public int Mileage { get; set; }

        public int HorsePower { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public string SellersCurrentPhone { get; set; }

        public ColorType Color { get; set; }

        public string Location { get; set; }

        public virtual ICollection<Image> Image
        {
            get { return this.image; }
            set { image = value; }
        }
    }
}
