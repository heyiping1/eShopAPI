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
        private readonly IShoppingCartItemService _shoppingCartItemService;
        private readonly IProductService _productService;
        public ShoppingCartItemController(IShoppingCartItemService shoppingCartItemService, IProductService productService)
        {
            _shoppingCartItemService = shoppingCartItemService;
            _productService = productService;
        }


        public IActionResult Index()
        {
            var collection = _shoppingCartItemService.GetAll();
            return View(collection);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Products = _productService.GetAll().Select(x => new SelectListItem()
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
                _shoppingCartItemService.Add(model);
                return RedirectToAction("Index");
            }
            ViewBag.Products = _productService.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View();
        }

        public IActionResult Delete(int id)
        {
            var item = _shoppingCartItemService.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(ShoppingCartItemRequestModel model)
        {
            _shoppingCartItemService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _shoppingCartItemService.GetById(id);
            ViewBag.Products = _productService.GetAll().Select(x => new SelectListItem()
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
                _shoppingCartItemService.Update(model);
                return RedirectToAction("Index");
            }
            ViewBag.Products = _productService.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            return View(model);

        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var item = _shoppingCartItemService.GetById(id);
            return View(item);
        }

    }
}
