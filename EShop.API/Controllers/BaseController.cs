using ApplicationCore;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models.Requests;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopAPI.Controllers
{
    [Route("api/[controller]/[action]")]

    [ApiController]
    public class BaseController<TModel, TRequest, TResponse> : ControllerBase where TModel : class where TRequest : class where TResponse : class
    {
        private readonly  IBaseServiceAsync<TRequest, TResponse> _serviceAsync;
        public BaseController(IBaseServiceAsync<TRequest, TResponse> serviceAsync)
        {
            _serviceAsync = serviceAsync;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _serviceAsync.GetAllAsync());
        }
        [HttpGet("{Id:int}")]
        public async Task<IActionResult> Get(int Id)
        {
            return Ok(await _serviceAsync.GetByIdAsync(Id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(TRequest request)
        {
            return Ok(await _serviceAsync.AddAsync(request));
        }

        [HttpPut]
        public async Task<IActionResult> Put(TRequest request)
        {
            return Ok(await _serviceAsync.UpdateAsync(request));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _serviceAsync.DeleteAsync(id));
        }
    }
}