﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthwindEntitiesLib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NorthwindService2.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly Northwind db;

        public CategoriesController(Northwind db)
        {
            this.db = db;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var cats = db.Categories.ToArray();
            return cats;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            var category = db.Categories.Find(id);
            return category;
        }        
    }
}
