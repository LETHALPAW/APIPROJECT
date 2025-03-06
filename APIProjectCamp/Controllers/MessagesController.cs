using APIProjectCamp.Context;
using APIProjectCamp.Dtos.MessageDtos;
using APIProjectCamp.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProjectCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;

		public MessagesController(IMapper mapper, ApiContext context)
		{
			_mapper = mapper;
			_context = context;
		}
		[HttpGet]
		public IActionResult GetMessage()
		{
			var values = _context.Messages.ToList();
			return Ok(_mapper.Map<List<ResultMessageDto>>(values));
		}
		[HttpPost]
		public IActionResult CreateMessage(CreateMessageDto createMessageDto)
		{
			var value = _mapper.Map<Message>(createMessageDto);
			_context.Messages.Add(value);	
			_context.SaveChanges();
			return Ok("Mesaj ekleme başarılı");
		}
		[HttpPut]
		public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
		{
			var value = _mapper.Map<Message>(updateMessageDto);
			_context.Messages.Update(value);
			_context.SaveChanges();
			return Ok("Mesaj güncelleme başarılı");
		}
		[HttpDelete]
		public IActionResult DeleteMessage(int id)
		{
			var value = _context.Messages.Find(id);
			_context.Messages.Remove(value);
			_context.SaveChanges();
			return Ok("Mesaj silme başarılı");
		}
		[HttpGet("GetMessage")]
		public IActionResult GetMessage(int id)
		{
			var value = _context.Messages.Find(id);
			return Ok(_mapper.Map<ResultMessageDto>(value));
		}
	}
}
