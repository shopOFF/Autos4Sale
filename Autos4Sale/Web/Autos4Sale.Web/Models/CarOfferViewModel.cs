using Autos4Sale.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autos4Sale.Web.Models
{
    public class CarOfferViewModel
    {
        public string AuthorEmail { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int YearManufacured { get; set; }
    }
}