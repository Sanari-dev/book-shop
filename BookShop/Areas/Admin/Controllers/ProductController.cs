using BookShop.DataAccess.Repository.IRepository;
using BookShop.Models;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private const string PRODUCT_PATH = @"images\product";
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Product> objProductList = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
            return View(objProductList);
        }

        public IActionResult Upsert(Guid? id)
        {
            ProductViewModel productViewModel = new()
            {
                CategoryList = CategoryList(),
                Product = new Product()
            };

            if (id != Guid.Empty)
            {
                productViewModel.Product = _unitOfWork.Product.Get(p => p.Id == id);
            }

            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Upsert(ProductViewModel productViewModel, IFormFile? file)
        {
            bool isCreate = productViewModel.Product.Id == null;

            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = DateTime.Now.ToString("yyyymmddhhmmss") + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, PRODUCT_PATH);

                    if (!string.IsNullOrEmpty(productViewModel.Product.ImageUrl))
                    {
                        string oldImagePath = Path.Combine(wwwRootPath, productViewModel.Product.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (FileStream fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    productViewModel.Product.ImageUrl = @"\" + PRODUCT_PATH + @"\" + fileName;
                }

                string infoStr = "";

                if (isCreate)
                {
                    _unitOfWork.Product.Add(productViewModel.Product);
                    infoStr = "created";
                }
                else
                {
                    _unitOfWork.Product.Update(productViewModel.Product);
                    infoStr = "updated";
                }

                _unitOfWork.Save();
                TempData["success"] = $"Product {infoStr} successfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Failed to create a Product";
                productViewModel.CategoryList = CategoryList();
                return View(productViewModel);
            }
        }

        private IEnumerable<SelectListItem> CategoryList()
        {
            return _unitOfWork.Category.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            });
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> objProductList = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
            return Json(new { data = objProductList });
        }

        [HttpDelete]
        public IActionResult Delete(Guid? id) 
        {
            Product? product = _unitOfWork.Product.Get(c => c.Id == id);
            if (product == null)
            {
                return Json(new { success = false, message = "Error while deleting"});
            }

            string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, product.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitOfWork.Product.Remove(product);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
