namespace Autos4Sale.Data.Migrations
{
    using Autos4Sale.Data.Models;
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
            // TODO: Get sample data for a model
            //if (!dbContext.Posts.Any())
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        var post = new Post()
            //        {
            //            Title = "Post " + i,
            //            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sit amet lobortis nibh. Nullam bibendum, tortor quis porttitor fringilla, eros risus consequat orci, at scelerisque mauris dolor sit amet nulla. Vivamus turpis lorem, pellentesque eget enim ut, semper faucibus tortor. Aenean malesuada laoreet lorem.",
            //            Author = dbContext.Users.First(x => x.Email == AdministratorUserName),
            //            CreatedOn = DateTime.Now
            //        };

            //        dbContext.Posts.Add(post);
            //    }
            //}
        }
    }
}