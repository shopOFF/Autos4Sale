namespace Autos4Sale.Data.Migrations
{
    using Autos4Sale.Data.Models;
    using Autos4Sale.Data.Models.Enums;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Autos4SaleDbContext>
    {
        private const string AdministratorUserName = "admin@gmail.com";
        private const string AdministratorPassword = "123456";

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(Autos4SaleDbContext dbContext)
        {
            this.SeedUsers(dbContext);
            this.SeedSampleData(dbContext);

            base.Seed(dbContext);
        }

        private void SeedUsers(Autos4SaleDbContext dbContext)
        {
            if (!dbContext.Roles.Any())
            {
                var roleName = "Admin";

                var roleStore = new RoleStore<IdentityRole>(dbContext);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var role = new IdentityRole { Name = roleName };
                roleManager.Create(role);

                var userStore = new UserStore<User>(dbContext);
                var userManager = new UserManager<User>(userStore);
                var user = new User
                {
                    UserName = AdministratorUserName,
                    Email = AdministratorUserName,
                    EmailConfirmed = true,
                    CreatedOn = DateTime.Now
                };

                userManager.Create(user, AdministratorPassword);
                userManager.AddToRole(user.Id, roleName);
            }
        }

        private void SeedSampleData(Autos4SaleDbContext dbContext)
        {
            if (!dbContext.CarOffers.Any())
            {
                for (int i = 0; i < 5; i++)
                {
                    var carOffer = new CarOffer()
                    {
                        // TODO: Image property must be set up
                        Brand = $"RandomBrand-{i}",
                        Model = $"Proto-Type-{i}",
                        Author = dbContext.Users.First(x => x.Email == AdministratorUserName),
                        CreatedOn = DateTime.Now,
                        Color = (ColorType)i,
                        Engine = (EngineType)i,
                        Transmission = TransmissionType.Manual,
                        CarCategory = (CarCategoryType)i,
                        YearManufacured = 2000 + i,
                        Mileage = 20000 + i,
                        HorsePower = 111 + i,
                        SellersCurrentPhone = "+0899101010",
                        Location = "Sofia, Mladost 1A",
                        Price = 1000 + i,
                        Description = "Perfektna, karana ot 93 godi6na baba, samo do magazina!"
                    };

                    dbContext.CarOffers.Add(carOffer);
                }
            }
        }
    }
}