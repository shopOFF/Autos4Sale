using Autos4Sale.Data.Models;

namespace Autos4Sale.Services.Contracts
{
    public interface IUserService
    {
        User ReturnCurrentUser(string currUserId = null, User currUser = null);
    }
}
