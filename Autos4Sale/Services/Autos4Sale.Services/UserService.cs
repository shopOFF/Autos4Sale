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
        private string currentUserId;
        private User currentUser;

        public UserService(IEfRepository<User> usersRepo)
        {
            if (usersRepo == null)
            {
                throw new ArgumentNullException("UsersRepo can not be null!");
            }

            this.usersRepo = usersRepo;
        }

        public string CurrentUserId
        {
            get { return this.currentUserId; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.currentUserId = HttpContext.Current.User.Identity.GetUserId();
                }
                else
                {
                    this.currentUserId = value;
                }
            }
        }

        public User CurrentUser
        {
            get { return this.currentUser; }
            private set
            {
                if (value == null)
                {
                    this.currentUser = this.usersRepo.GetAll.Where(x => x.Id == this.currentUserId).FirstOrDefault();
                }
                else
                {
                    this.currentUser = value;
                }
            }
        }

        public User ReturnCurrentUser(string currUserId = null, User currUser = null)
        {
            this.CurrentUserId = currUserId;
            this.CurrentUser = currUser;

            return this.currentUser;
        }

        public IQueryable<User> GetAllUsers()
        {
            return this.usersRepo.GetAll;
        }
    }
}
