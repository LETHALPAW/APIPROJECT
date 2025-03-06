using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProjectCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
		[HttpGet]
		public IActionResult Get()
		{
			return Ok("Testimonials");
		}
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return Ok("Testimonials by id");
		}
		[HttpPost]
		public IActionResult Post()
		{
			return Ok("Testimonials added");
		}
		[HttpPut]
		public IActionResult Put()
		{
			return Ok("Testimonials updated");
		}
		[HttpDelete]
		public IActionResult Delete()
		{
			return Ok("Testimonials deleted");
		}
	}
}
