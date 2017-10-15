using Autos4Sale.Data.Models;
using Autos4Sale.Data.Models.Contracts;
using Autos4Sale.Web.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;

namespace Autos4Sale.Web.Areas.Administration.ViewModels
{
    public class UserViewModel : IdentityUser, IAuditable, IDeletable, IMapFrom<User>
    {
        public bool IsDeleted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DeletedOn { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }
    }
}