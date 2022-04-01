﻿using LojaMargun_Domain.Core.Interfaces.Services;
using LojaMargun_Domain.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace LojaMargun_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) => _productService = productService;

        [HttpPost]
        public async Task<ActionResult> AddProducts(ProductDTO productDTO)
        {
            if (productDTO == null)
                return NotFound();

            await _productService.Add(productDTO);
            
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