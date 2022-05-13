using LojaMargun_Domain.Core.Interfaces.Services;
using LojaMargun_Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace LojaMargun_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService productService) => _itemService = productService;

        [HttpGet]
        public async Task<IEnumerable<ItemDTO>> GetAllProduct() => await _itemService.GetAll();

        [HttpPost]
        public async Task<ActionResult> AddProducts(ItemDTO itemDTO)
        {
            if (itemDTO == null)
                return NotFound();

            await _itemService.Add(itemDTO);
            
            return Ok("Produto cadastrado com sucesso!");
        }

        [HttpPost("SaveImage")]
        public async Task<ActionResult> SaveImage()
        {
            var image = Request.Form.Files[0];
            byte[] data;
            
            using(var read = image.OpenReadStream())
                using(var memory = new MemoryStream())
            {
                await read.CopyToAsync(memory);
                data = memory.ToArray();
            }
            return Ok(new { Image = data});
        }
    }
}
