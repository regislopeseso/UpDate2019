using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        public SellersController(SellerService sellerService)
        {
            this._sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list = this._sellerService.FindAll();
            return View(list);
        }



    }
}
