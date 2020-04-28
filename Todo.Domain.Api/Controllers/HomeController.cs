using System;
using Microsoft.AspNetCore.Mvc;

namespace Todo.Domain.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult get()
        {
            return Ok(DateTime.Now);
        }
    }
}