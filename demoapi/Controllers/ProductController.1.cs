using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using demoapi.Models;

namespace demoapi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductController : Controller
    {
        [HttpGet]        
        public string AllProduct()
        {
            return "Hello";
        }
        [HttpGet("{name}")]        
        public string Show(string name)
        {
            return "Hello : "+ name;
        }
        [HttpPost]        
        public string CreateProduct ()
        {
            return "a";
        }
        [HttpPut]        
        public string UpdateProduct()
        {
            return "b";
        }
        
    }
}
