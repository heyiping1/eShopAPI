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
        private readonly IProductCategoryServiceAsync _categoryServiceAsync;
        private readonly IProductServiceAsync _productServiceAsync;
        public CategoryController(IProductCategoryServiceAsync productCategoryServiceAsync, IProductServiceAsync productServiceAsync)
        {
            _categoryServiceAsync = productCategoryServiceAsync;
            _productServiceAsync = productServiceAsync;
        }


        public async Task<IActionResult> Index()
        {
            var collection = await _categoryServiceAsync.GetAllAsync();
            return View(collection);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return awView();
        }

        [HttpPost]
        public IActionResult Create(ProductCategoryRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _categoryServiceAsync.AddAsync(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var item = _categoryServiceAsync.GetByIdAsync(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(ProductCategoryRequestModel model)
        {
            _categoryServiceAsync.DeleteAsync(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _categoryServiceAsync.GetByIdAsync(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ProductCategoryRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _categoryServiceAsync.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);

        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var item = _categoryServiceAsync.GetByIdAsync(id);
            ViewBag.Products = _productServiceAsync.GetProductsByCategoryAsync(id, 1, 30);
            return View(item);
        }

    }
}
