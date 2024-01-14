using BookShop.DataAccess.Repository.IRepository;
using BookShop.Models;
using BookShop.Models.ViewModels;
using BookShop.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = StaticDetails.ROLE_ADMIN)]
    public class ProductController : Controller
    {
        private const string PRODUCT_PATH = @"images\product";
        private readonly IProductRepository _productRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IProductRepository productRepo, ICategoryRepository categoryRepo, IWebHostEnvironment webHostEnvironment)
        {
            _productRepo = productRepo;
            _categoryRepo = categoryRepo;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Product> objProductList = _productRepo.GetAll(includeProperties: "Category").ToList();
            return View(objProductList);
        }

        public IActionResult Upsert(Guid? id)
        {
            ProductViewModel productVM = new()
            {
                CategoryList = CategoryList(),
                Product = new Product()
                {
                    Id = Guid.NewGuid(),
                }
            };

            if (id != Guid.Empty)
            {
                productVM.Product = _productRepo.Get(p => p.Id == id);
            }

            return View(productVM);
        }

        [HttpPost]
        public IActionResult Upsert(ProductViewModel productVM, IFormFile? file)
        {
            bool isCreate = productVM.Product.Id == null;

            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = DateTime.Now.ToString("yyyymmddhhmmss") + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, PRODUCT_PATH);

                    if (!string.IsNullOrEmpty(productVM.Product.ImageUrl))
                    {
                        string oldImagePath = Path.Combine(wwwRootPath, productVM.Product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (FileStream fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    productVM.Product.ImageUrl = @"\" + PRODUCT_PATH + @"\" + fileName;
                }

                string infoStr = "";

                if (isCreate)
                {
                    _productRepo.Add(productVM.Product);
                    infoStr = "created";
                }
                else
                {
                    _productRepo.Update(productVM.Product);
                    infoStr = "updated";
                }

                _productRepo.Save();
                TempData["success"] = $"Product {infoStr} successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["error"] = "Failed to create a Product";
                productVM.CategoryList = CategoryList();
                return View(productVM);
            }
        }

        private IEnumerable<SelectListItem> CategoryList()
        {
            return _categoryRepo.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            });
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> objProductList = _productRepo.GetAll(includeProperties: "Category").ToList();
            return Json(new { data = objProductList });
        }

        [HttpDelete]
        public IActionResult Delete(Guid? id)
        {
            Product? product = _productRepo.Get(c => c.Id == id);
            if (product == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, product.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _productRepo.Remove(product);
            _productRepo.Save();

            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
