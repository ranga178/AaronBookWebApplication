using AaronBookWebApplication.Data;
using AaronBookWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace AaronBookWebApplication.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
