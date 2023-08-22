using Blog.Data;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controller
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(
            [FromServices] BlogDataContext context)
        {

            return Ok(context.Categories.ToList());
        }

    }
}
