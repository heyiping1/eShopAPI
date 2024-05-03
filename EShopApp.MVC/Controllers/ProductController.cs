using ApplicationCore.Contracts.Services;
using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EShop.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductCategoryService _categoryService;
        public ProductController(IProductService productService, IProductCategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
            var collection = _productService.GetAll();
            return View(collection);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = _categoryService.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(model);
                return RedirectToAction("Index");
            }
            ViewBag.Categories = _categoryService.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View();
        }

        public IActionResult Delete(int id)
        {
            var item = _productService.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(ProductRequestModel model)
        {
            _productService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _productService.GetById(id);
            ViewBag.Categories = _categoryService.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ProductRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(model);
                return RedirectToAction("Index");
            }
            ViewBag.Categories = _categoryService.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View(model);

        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var item = _productService.GetById(id);
            ViewBag.CategoryName = _categoryService.GetById(item.CategoryId).Name;
            return View(item);
        }

    }
}
