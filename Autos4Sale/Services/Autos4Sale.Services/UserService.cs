using Autos4Sale.Data.Common.Contracts;
using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web;

namespace Autos4Sale.Services
{
    public class UserService : IUserService
    {
        private readonly IEfRepository<User> usersRepo;
        private readonly string currentUserId;
        private readonly User currentUser;

        public UserService(IEfRepository<User> usersRepo)
        {
            if (usersRepo == null)
            {
                throw new ArgumentNullException("UsersRepo can not be null!");
            }

            this.usersRepo = usersRepo;
            this.currentUserId = HttpContext.Current.User.Identity.GetUserId();
            this.currentUser = this.usersRepo.GetAll.Where(x => x.Id == this.currentUserId).FirstOrDefault();
        }

        public User ReturnCurrentUser()
        {
            return this.currentUser;
        }
    }
}
