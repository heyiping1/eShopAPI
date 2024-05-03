using ApplicationCore.Contracts.Services;
using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EShop.MVC.Controllers
{
    public class ShipperController : Controller
    {
        private readonly IShipperService _shipperService;
        public ShipperController(IShipperService shipperService)
        {
            _shipperService = shipperService;
        }


        public IActionResult Index()
        {
            var collection = _shipperService.GetAll();
            return View(collection);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ShipperRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _shipperService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var item = _shipperService.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(ShipperRequestModel model)
        {
            _shipperService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _shipperService.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ShipperRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _shipperService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);

        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var item = _shipperService.GetById(id);
            return View(item);
        }

    }
}
