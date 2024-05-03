using ApplicationCore.Contracts.Services;
using ApplicationCore.Models.Requests;
using ApplicationCore.Models.Responses;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EShop.MVC.Controllers
{
    public class PromotionController : Controller
    {
        private readonly IPromotionService _promotionService;
        public PromotionController(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }


        public IActionResult Index()
        {
            var collection = _promotionService.GetAll();
            return View(collection);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PromotionRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _promotionService.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var item = _promotionService.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(PromotionRequestModel model)
        {
            _promotionService.Delete(model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _promotionService.GetById(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(PromotionRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _promotionService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);

        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var item = _promotionService.GetById(id);
            return View(item);
        }

    }
}
