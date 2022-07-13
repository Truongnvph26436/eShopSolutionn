using System.Collections.Generic;
using System.Threading.Tasks;
using eShopsolution.Application.Catalog.Products;
using eShopSolution.ViewModels.Catalog.ProductImages;
using eShopSolution.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductsController(IPublicProductService publicProductService,
            IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        #region 1. IPublicProductService

        //URL://http://localhost:port/product?pageIndex=1&pageSize=10&categoryId=
        [HttpGet("public-paging/{languageId}")]
        public async Task<IActionResult> GetAllPaging(string languageId,
            [FromQuery] GetPublicProductPagingRequest request)
        {
            var products = await _publicProductService.GetAllByCategory(languageId, request);
            return Ok(products);
        }

        #endregion

        #region 2. IManageProductService

        //URL://http://localhost:port/1
        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var products = await _manageProductService.GetById(productId, languageId);
            if (products == null)
            {
                return BadRequest("Cannot find product");
            }

            return Ok(products);
        }

        //URL://http://localhost:port/product
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            var productId = await _manageProductService.Create(request);
            if (productId == 0)
            {
                return BadRequest();
            }

            var product = await _manageProductService.GetById(productId, request.LanguageId);
            return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            var affectedResult = await _manageProductService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _manageProductService.Delete(productId);
            if (affectedResult == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int id, decimal newPrice)
        {
            var isSuccessful = await _manageProductService.UpdatePrice(id, newPrice);
            if (isSuccessful)
            {
                return Ok();
            }

            return BadRequest();
        }

        #endregion

        #region Images

        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            var imageId = await _manageProductService.AddImage(productId, request);
            if (imageId == 0)
            {
                return BadRequest();
            }

            var image = await _manageProductService.GetImageById(imageId);
            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            var result = await _manageProductService.UpdateImage(imageId, request);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            var result = await _manageProductService.RemoveImage(imageId);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _manageProductService.GetImageById(imageId);
            if (image == null)
            {
                return BadRequest("Cannot find product");
            }

            return Ok(image);
        }

        #endregion
    }
}