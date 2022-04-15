using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prodcat.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace prodcat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext dbContext;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            dbContext = context;
        }

        public IActionResult Index()
        {
            List<Product> AllProducts = dbContext.Products.ToList();
            ViewBag.AllProducts = AllProducts;

            return View();
        }


        [HttpPost("NewProduct")]
        public IActionResult NewProduct(Product newProduct)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newProduct);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            List<Category> AllCategories = dbContext.Categories.ToList();
            ViewBag.AllCategories = AllCategories;

            return View();
        }


        [HttpPost("NewCategory")]
        public IActionResult NewCategory(Category NewCategory)
        {
            Console.WriteLine($"\n\n\n\n\n\n\n\nForm is process");
            if(ModelState.IsValid)
            {
                Console.WriteLine($"\n\n\n\n\n\n\n\nForm is Valid");
                dbContext.Add(NewCategory);
                dbContext.SaveChanges();
                return RedirectToAction("Categories");
            }
            else
            {
                
                Console.WriteLine($"\n\n\n\n\n\n\n\nForm is Invalid");
                return View("Categories");
            }
        }

        [HttpGet("products/{id}")]
        public IActionResult Products(int id)
        {

            Product SelectedProduct = dbContext.Products.FirstOrDefault(p => p.ProductId == id);
            ViewBag.SelectedProduct = SelectedProduct;

            List<Category> SelectedCategories = dbContext.Categories.Where(c => c.ProductsIn.Any(p => p.ProductId == id)).ToList();
            ViewBag.SelectedCategories = SelectedCategories;

            List<Category> NotInCategories = dbContext.Categories.Where(c => !c.ProductsIn.Any(p => p.ProductId == id)).ToList();
            ViewBag.NotInCategories = NotInCategories;

            return View("Product");
        }

        [HttpPost("NewProdCat")]
        public IActionResult NewProdCat(ProductCategory NewProdCat)

        {
            if(ModelState.IsValid)
            {
                dbContext.Add(NewProdCat);
                dbContext.SaveChanges();
                return RedirectToAction("Products", new {id = NewProdCat.ProductId});
            }
            else
            {
                Console.WriteLine($"\n\n\n\nModel is invalid");
                Console.WriteLine($"Text: {NewProdCat.CategoryId}");
                Console.WriteLine($"Text: {NewProdCat.ProductId}");
                Console.WriteLine($"**********\n\n\n\n");
                
                
                return RedirectToAction("Products", new {id = NewProdCat.ProductId});
            }
        }

        [HttpGet("categories/{id}")]
        public IActionResult Category(int id)
        {
            Category SelectedCategory = dbContext.Categories.FirstOrDefault(c => c.CategoryId == id);
            ViewBag.SelectedCategory = SelectedCategory;

            List<Product> SelectedProducts = dbContext.Products
            .Include(p => p.CategoriesIn)
            .ThenInclude(p => p.Category)
            .Where(p => p.CategoriesIn.Any(pc => pc.CategoryId == id))
            .ToList();
            ViewBag.SelectedProducts = SelectedProducts;

            List<Product> NotInProducts = dbContext.Products
            .Include(p => p.CategoriesIn)
            .ThenInclude(p => p.Category)
            .Where(p => !p.CategoriesIn.Any(pc => pc.CategoryId == id))
            .ToList();
            ViewBag.NotInProducts = NotInProducts;

            return View("Category");
        }

        [HttpPost("NewCatProd")]
        public IActionResult NewCatProd(ProductCategory NewCatProd)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(NewCatProd);
                dbContext.SaveChanges();
                return RedirectToAction("Category", new {id = NewCatProd.CategoryId});
            }
            else
            {
                return RedirectToAction("Category", new {id = NewCatProd.CategoryId});
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
