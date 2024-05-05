using ApplicationCore.Contracts.Services;
using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EShop.MVC.Controllers
{
    public class ShoppingCartItemController : Controller
    {
        private readonly IShoppingCartItemServiceAsync _shoppingCartItemServiceAsync;
        private readonly IProductServiceAsync _productServiceAsync;
        public ShoppingCartItemController(IShoppingCartItemServiceAsync shoppingCartItemServiceAsync, IProductServiceAsync productServiceAsync)
        {
            _shoppingCartItemServiceAsync = shoppingCartItemServiceAsync;
            _productServiceAsync = productServiceAsync;
        }


        public IActionResult Index()
        {
            var collection = _shoppingCartItemServiceAsync.GetAllAsync();
            return View(collection);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Products = _productServiceAsync.GetAllAsync().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View();
        }

        [HttpPost]
        public IActionResult Create(ShoppingCartItemRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _shoppingCartItemServiceAsync.AddAsync(model);
                return RedirectToAction("Index");
            }
            ViewBag.Products = _productServiceAsync.GetAllAsync().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View();
        }

        public IActionResult Delete(int id)
        {
            var item = _shoppingCartItemServiceAsync.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(ShoppingCartItemRequestModel model)
        {
            _shoppingCartItemServiceAsync.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _shoppingCartItemServiceAsync.GetById(id);
            ViewBag.Products = _productServiceAsync.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ShoppingCartItemRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _shoppingCartItemServiceAsync.Update(model);
                return RedirectToAction("Index");
            }
            ViewBag.Products = _productServiceAsync.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View(model);

        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var item = _shoppingCartItemServiceAsync.GetById(id);
            return View(item);
        }

    }
}
