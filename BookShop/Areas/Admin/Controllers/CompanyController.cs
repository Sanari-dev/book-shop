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
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepo;

        public CompanyController(ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }

        public IActionResult Index()
        {
            List<Company> objCompanyList = _companyRepo.GetAll().ToList();
            return View(objCompanyList);
        }

        public IActionResult Upsert(Guid? id)
        {
            Company company = new Company();

            if (id != null)
            {
                company = _companyRepo.Get(p => p.Id == id);
            }

            return View(company);
        }

        [HttpPost]
        public IActionResult Upsert(Company company)
        {
            bool isCreate = company.Id == Guid.Empty;

            if (ModelState.IsValid)
            {
                string infoStr = "";

                if (isCreate)
                {
                    _companyRepo.Add(company);
                    infoStr = "created";
                }
                else
                {
                    _companyRepo.Update(company);
                    infoStr = "updated";
                }

                _companyRepo.Save();
                TempData["success"] = $"Company {infoStr} successfully";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["error"] = "Failed to create a Company";
                return View(company);
            }
            
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> objCompanyList = _companyRepo.GetAll().ToList();
            return Json(new { data = objCompanyList });
        }

        [HttpDelete]
        public IActionResult Delete(Guid? id) 
        {
            Company? company = _companyRepo.Get(c => c.Id == id);
            if (company == null)
            {
                return Json(new { success = false, message = "Error while deleting"});
            }

            _companyRepo.Remove(company);
            _companyRepo.Save();

            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
