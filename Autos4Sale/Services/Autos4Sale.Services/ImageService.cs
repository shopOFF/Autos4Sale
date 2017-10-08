using Autos4Sale.Data.Models;
using Autos4Sale.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Autos4Sale.Data.Common.Contracts;

namespace Autos4Sale.Services
{
    public class ImageService : IImageService
    {
        private readonly IEfRepository<User> usersRepo;
        private readonly string currentUserId;
        private readonly User currentUser; 

        public ImageService(IEfRepository<User> usersRepo)
        {
            this.usersRepo = usersRepo;
            this.currentUserId= HttpContext.Current.User.Identity.GetUserId();
            this.currentUser= this.usersRepo.GetAll.Where(x => x.Id == this.currentUserId).FirstOrDefault();
        }

        private string RenameImage(int counter)
        {
            return $"{currentUser.Email}-image-{counter}-{Guid.NewGuid()}.jpg";
        }
        public ICollection<Image> SaveImages(IEnumerable<HttpPostedFileBase> images)
        {
            var counter = 1;
            var collectionOfImages = new List<Image>();

            foreach (var image in images)
            {
                var imageNewName = this.RenameImage(counter);

                var imageModel = new Image()
                {
                    ImageUrl = imageNewName,
                    Author = currentUser
                };

                collectionOfImages.Add(imageModel);

                image.SaveAs(HttpContext.Current.Server.MapPath($"~/Images/{imageNewName}"));

                counter++;
            }

            return collectionOfImages;
        }
    }
}
