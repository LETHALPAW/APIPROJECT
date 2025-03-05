using APIProjectCamp.Context;
using APIProjectCamp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProjectCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
		private readonly ApiContext _context;

		public ChefsController(ApiContext context)
		{
			_context = context;
		}
		[HttpGet]
		public IActionResult GetChef()
		{
			var values = _context.Chefs.ToList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateChef(Chef chef)
		{
			_context.Chefs.Add(chef);
			_context.SaveChanges();
			return Ok("Şef başarı ile eklendi");
		}

		[HttpDelete]
		public IActionResult DeleteChef(int id)
		{
			var values = _context.Chefs.Find(id);
			_context.Chefs.Remove(values);
			_context.SaveChanges();
			return Ok("Şef başarı ile silindi");
		}

		[HttpGet("GetChef")]
		public IActionResult GetCategory(int id)
		{
			var value = _context.Chefs.Find(id);
			return Ok(value);
		}

		[HttpPut]
		public IActionResult UpdateChef(Chef chef)
		{
			_context.Chefs.Update(chef);
			_context.SaveChanges();
			return Ok("Şef başarı ile güncellendi");
		}
	}
}

