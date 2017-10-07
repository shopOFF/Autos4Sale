using Autos4Sale.Services.Contracts;
using Autos4Sale.Web.Infrastructure;
using Autos4Sale.Web.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Autos4Sale.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarOffersService carOffersService;

        public HomeController(ICarOffersService carOffersService)
        {
            this.carOffersService = carOffersService;
        }

        public ActionResult Index()
        {
            var carOffers = this.carOffersService
                .GetAll()
                .MapTo<CarOfferViewModel>()
                .ToList();

            return View(carOffers);
        }

       // [Authorize(Roles = "Admin, User")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}