﻿using LojaMargun_Domain.Core.Interfaces.Services;
using LojaMargun_Domain.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaMargun_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryDTO>> GetAll() => await _categoryService.GetAll();

        [HttpGet("GET")]
        public string Get() => "OI";
    }
}