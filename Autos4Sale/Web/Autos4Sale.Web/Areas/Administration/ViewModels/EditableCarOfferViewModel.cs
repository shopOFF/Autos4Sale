using Autos4Sale.Data.Models;
using Autos4Sale.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using System.ComponentModel.DataAnnotations;
using Autos4Sale.Data.Models.Enums;

namespace Autos4Sale.Web.Areas.Administration.ViewModels
{
    public class EditableCarOfferViewModel : IMapFrom<CarOffer>
    {
        private ICollection<Image> image;

        public EditableCarOfferViewModel()
        {
            this.image = new HashSet<Image>();
        }

        [ScaffoldColumn(false)]
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public User Author { get; set; }

        [Display(Name = "Car Manufacurer")]
        [Required(ErrorMessage = "Car Manufacurer is required!")]
        [StringLength(30, ErrorMessage = "Name can be no larger than 30 characters!")]
        public string Brand { get; set; }

        [Display(Name = "Car Model")]
        [Required(ErrorMessage = "Car Model is required!")]
        [StringLength(30, ErrorMessage = "Name can be no larger than 30 characters!")]
        public string Model { get; set; }

        [Display(Name = "Year Manufacured")]
        [Required(ErrorMessage = "Year Manufacured is required!")]
        [Range(1900, 2018, ErrorMessage = "Car can not be manufactured earlier than 1900 and later than 2018!")]
        public int YearManufacured { get; set; }

        [Required(ErrorMessage = "Transmission is required!")]
        [Range(1, 100, ErrorMessage = "Transmission is required!")]
        public TransmissionType Transmission { get; set; }

        [Required(ErrorMessage = "Engine is required!")]
        [Range(1, 100, ErrorMessage = "Engine is required!")]
        public EngineType Engine { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Car Category is required!")]
        [Range(1, 100, ErrorMessage = "Car Category is required!")]
        public CarCategoryType CarCategory { get; set; }

        [Display(Name = "Mileage (Km)")]
        [Required(ErrorMessage = "Mileage is required!")]
        [Range(0, 2000000, ErrorMessage = "Car's mileage can not be less than 0km and more than 2000000km!")]
        public int Mileage { get; set; }

        [Display(Name = "Horse Power")]
        [Required(ErrorMessage = "Horse Power is required!")]
        [Range(0, 5000, ErrorMessage = "Car's horse power can not be less than 0hp!")]
        public int HorsePower { get; set; }

        [StringLength(9999, ErrorMessage = "Description can be no larger than 9999 characters!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required!")]
        [Range(0, 10000000, ErrorMessage = "Car's price can not be less than 0$ and more than billion $!")]
        public int Price { get; set; }

        [Display(Name = "Seller's Phone")]
        [Required(ErrorMessage = "Seller's Phone is required!")]
        [StringLength(70, ErrorMessage = "Seller's Phone can be no larger than 70 characters!")]
        public string SellersCurrentPhone { get; set; }

        [Required(ErrorMessage = "Color is required!")]
        [Range(1, 300, ErrorMessage = "Color is required!")]
        public ColorType Color { get; set; }

        [Required(ErrorMessage = "Seller's Location is required!")]
        [StringLength(70, ErrorMessage = "Seller's Location can be no larger than 70 characters!")]
        public string Location { get; set; }

        [FileExtensions(Extensions = "jpg,jpeg,png,bmp", ErrorMessage = "Please select an Image file!")]
        [ScaffoldColumn(false)]
        public ICollection<Image> Image
        {
            get { return this.image; }
            set { image = value; }
        }
    }
}