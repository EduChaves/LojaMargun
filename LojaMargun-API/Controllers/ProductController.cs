using LojaMargun_Domain.Core.Interfaces.Services;
using LojaMargun_Domain.DTOs;
using LojaMargun_Infra_CrossCutting.Connected_Services.CorreiosApi;
using LojaMargun_Infra_CrossCutting.Connected_Services.Interfaces.CorreiosApi;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace LojaMargun_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ICorreiosApiConfig _correiosApi;

        public ProductController(IProductService productService, ICorreiosApiConfig correiosApi)
        {
            _productService = productService;
            _correiosApi = correiosApi;
        } 

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAllProduct() => await _productService.GetAll();

        [HttpGet("{id}")]
        public async Task<ProductDTO> GetProduct(int id) => await _productService.GetById(id);

        [HttpGet("GetLocation/{value}")]
        public async Task<CorreiosResponse> GetLocation(string value)
        {
            return await _correiosApi.FindLocation(value);
        }

        [HttpPost]
        public async Task<IActionResult> AddProducts(ProductDTO productDTO)
        {
            if (productDTO == null)
                return NotFound();

            await _productService.Add(productDTO);
            
            return Ok();
        }
    }
}
