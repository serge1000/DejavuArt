﻿using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
    {
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
        {
        private readonly DejavuContext _context;
        public ProductsController(DejavuContext context)
            {
            _context = context;
            }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
            {
            return await _context.Products.ToListAsync();
            }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
            {
            return await _context.Products.FindAsync(id);
            }

        [HttpGet("ProductType/{producttype}")]
        public async Task<ActionResult<string>> GetProduct(string producttype)
            {
            //return await _context.Products.FindAsync(id);
            switch (producttype)
                {
                case "individual":
                    return "iiiiiiiiii";
                case "commercial":
                    return "ccccccccccccc";
                }
            return "0";
            }

        }
    }