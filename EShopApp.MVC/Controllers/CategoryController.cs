using ApplicationCore.Contracts.Services;
using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EShop.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductCategoryService _categoryService;
        private readonly IProductService _productService;
        public CategoryController(IProductCategoryService productCategoryService, IProductService productService)
        {
            _categoryService = productCategoryService;
            _productService = productService;
        }


        public IActionResult Index()
        {
            var collection = _categoryService.GetAll();
            return View(collection);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductCategoryRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var item = _categoryService.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(ProductCategoryRequestModel model)
        {
            _categoryService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _categoryService.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ProductCategoryRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);

        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var item = _categoryService.GetById(id);
            ViewBag.Products = _productService.GetAll()
                .Where(x => x.CategoryId == id);
            return View(item);
        }

    }
}
