using Autos4Sale.Data.Models;
using System.Linq;

namespace Autos4Sale.Services.Contracts
{
    public interface IUserService
    {
        User ReturnCurrentUser(string currUserId = null, User currUser = null);

        IQueryable<User> GetAllUsers();
    }
}
