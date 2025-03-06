using APIProjectCamp.Context;
using APIProjectCamp.Dtos.ContactDtos;
using APIProjectCamp.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProjectCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _context;

		public ContactsController(ApiContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult GetContact()
		{
			var values = _context.Contacts.ToList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateContact(CreateContactDto createContactDto)
		{
			Contact contact = new Contact
			{
				MapLocation = createContactDto.MapLocation,
				Adress = createContactDto.Adress,
				Phone = createContactDto.Phone,
				Email = createContactDto.Email,
				OpenHours = createContactDto.OpenHours
				
			};
			_context.Contacts.Add(contact);
			_context.SaveChanges();	
			return Ok("Ekleme başarılı");
		}
		[HttpDelete]
		public IActionResult DeleteContact(int id)
		{
			var values = _context.Contacts.Find(id);
			_context.Contacts.Remove(values);
			_context.SaveChanges();
			return Ok("Silme başarılı");
		}
		[HttpGet("GetContact")]
		public IActionResult GetContact(int id)
		{
			var value = _context.Contacts.Find(id);
			return Ok(value);
		}
		[HttpPut]
		public IActionResult UpdateContact(UpdateContactDto updateContactDto)
		{
			Contact contact = new Contact
			{
				ContactId = updateContactDto.ContactId,
				MapLocation = updateContactDto.MapLocation,
				Adress = updateContactDto.Adress,
				Phone = updateContactDto.Phone,
				Email = updateContactDto.Email,
				OpenHours = updateContactDto.OpenHours
			};
			_context.Contacts.Update(contact);
			_context.SaveChanges();
			return Ok("Güncelleme başarılı");
		}
	}
}
