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
        private readonly IProductServiceAsync _productServiceAsync;
        private readonly IProductCategoryServiceAsync _categoryServiceAsync;
        public ProductController(IProductServiceAsync productServiceAsync, IProductCategoryServiceAsync categoryServiceAsync)
        {
            _productServiceAsync = productServiceAsync;
            _categoryServiceAsync = categoryServiceAsync;
        }


        public async Task<IActionResult> Index()
        {
            var collection = await _productServiceAsync.GetAllAsync();
            return View(collection);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryServiceAsync.GetAllAsync();
            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await _productServiceAsync.AddAsync(model);
                return RedirectToAction("Index");
            }
            var categories = await _categoryServiceAsync.GetAllAsync();
            ViewBag.Categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var item = await _productServiceAsync.GetByIdAsync(id);
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ProductRequestModel model)
        {
            await _productServiceAsync.DeleteAsync(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var item = await _productServiceAsync.GetByIdAsync(id);
            var category = await _categoryServiceAsync.GetAllAsync();
            ViewBag.Categories = category.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await _productServiceAsync.UpdateAsync(model);
                return RedirectToAction("Index");
            }
            var category = await _categoryServiceAsync.GetAllAsync();
            ViewBag.Categories = category.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var item = await _productServiceAsync.GetByIdAsync(id);
            ViewBag.CategoryName = (await _categoryServiceAsync.GetByIdAsync(item.CategoryId)).Name;
            return View(item);
        }

    }
}
