using BookShop.DataAccess.Repository.IRepository;
using BookShop.Models;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly IShoppingCartRepository _shoppingCartRepo;
        private ShoppingCartViewModel _shoppingCartVM { get; set; }

        public CartController(IShoppingCartRepository shoppingCartRepo)
        {
            _shoppingCartRepo = shoppingCartRepo;
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            _shoppingCartVM = new ShoppingCartViewModel()
            {
                ShoppingCartList = _shoppingCartRepo.GetAll(u => u.ApplicationUserId == userId, includeProperties: "Product").ToList()
            };

            foreach (var cart in _shoppingCartVM.ShoppingCartList)
            {
                cart.Price = GetPriceBasedOnQuantity(cart);
                _shoppingCartVM.OrderTotal += (cart.Price * cart.Count);
            }

            return View(_shoppingCartVM);
        }

        public IActionResult Summary() 
        {
            return View();
        }

        public IActionResult Plus(Guid cartId)
        {
            var cartFromDb = _shoppingCartRepo.Get(u => u.Id == cartId);
            cartFromDb.Count += 1;
            _shoppingCartRepo.Update(cartFromDb);
            _shoppingCartRepo.Save();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Minus(Guid cartId)
        {
            var cartFromDb = _shoppingCartRepo.Get(u => u.Id == cartId);
            if (cartFromDb.Count == 1)
            {
                _shoppingCartRepo.Remove(cartFromDb);
            }
            else
            {
                cartFromDb.Count -= 1;
                _shoppingCartRepo.Update(cartFromDb);
            }

            _shoppingCartRepo.Save();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(Guid cartId)
        {
            var cartFromDb = _shoppingCartRepo.Get(u => u.Id == cartId);
            _shoppingCartRepo.Remove(cartFromDb);

            _shoppingCartRepo.Save();
            return RedirectToAction(nameof(Index));
        }

        private double GetPriceBasedOnQuantity(ShoppingCart shoppingCart)
        {
            if (shoppingCart.Count <= 50)
            {
                return shoppingCart.Product.Price;
            }
            else
            {
                if (shoppingCart.Count <= 100)
                {
                    return shoppingCart.Product.Price50;
                }
                else
                {
                    return shoppingCart.Product.Price100;
                }
            }
        }
    }
}
