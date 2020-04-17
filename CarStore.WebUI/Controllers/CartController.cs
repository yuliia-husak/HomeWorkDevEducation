using System.Linq;
using System.Web.Mvc;
using CarStore.Domain.Entities;
using CarStore.Domain.Abstract;
using CarStore.WebUI.Models;

namespace GameStore.WebUI.Controllers
{
    public class CartController : Controller
    {
        private ICarRepository repository;
        public CartController(ICarRepository repo)
        {
            repository = repo;
        }

        public RedirectToRouteResult AddToCart(int carId, string returnUrl)
        {
            Car car = repository.Cars
                .FirstOrDefault(g => g.CarId == carId);

            if (car != null)
            {
                GetCart().AddItem(car, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(int carId, string returnUrl)
        {
            Car car = repository.Cars
                .FirstOrDefault(g => g.CarId == carId);

            if (car != null)
            {
                GetCart().RemoveLine(car);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}