using Autos4Sale.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos4Sale.Data
{
    public class Autos4SaleDbContext : IdentityDbContext<User>
    {
        public Autos4SaleDbContext()
            : base("Autos4SaleDB", throwIfV1Schema: false)
        {
        }

        //public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<CarOffer> CarOffers { get; set; }

        public virtual IDbSet<Image> Images { get; set; }


        public static Autos4SaleDbContext Create()
        {
            return new Autos4SaleDbContext();
        }
    }
}
