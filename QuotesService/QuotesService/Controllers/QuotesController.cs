﻿using Microsoft.AspNetCore.Mvc;
using QuotesService.Model;

namespace QuotesService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuotesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(Quote quote)
        {
            return new OkObjectResult("royale with cheese");
        }

        [HttpGet]
        [Route("{id:Guid?}")]
        public IActionResult Read(Guid? id = null)
        {
            return new OkObjectResult("royale with cheese");

        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(Guid id, Quote quote)
        {
            return new OkObjectResult("royale with cheese");

        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(Guid id)
        {
            return new OkObjectResult("royale with cheese");
        }
    }
}
