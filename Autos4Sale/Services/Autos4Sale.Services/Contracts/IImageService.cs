using Autos4Sale.Data.Models;
using System.Collections.Generic;
using System.Web;

namespace Autos4Sale.Services.Contracts
{
    public interface IImageService
    {
        ICollection<Image> SaveImages(IEnumerable<HttpPostedFileBase> images);

        string RenameImage(int counter, string currUserId = null, User currUser = null);
    }
}
