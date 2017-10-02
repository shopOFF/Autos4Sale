using Autos4Sale.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos4Sale.Data
{
    public class Auto4SaleDbContext : IdentityDbContext<User>
    {
        public Auto4SaleDbContext()
            : base("Autos4SaleDB", throwIfV1Schema: false)
        {
        }

        public static Auto4SaleDbContext Create()
        {
            return new Auto4SaleDbContext();
        }
    }
}
