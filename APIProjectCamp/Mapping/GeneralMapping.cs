using APIProjectCamp.Dtos.FeatureDtos;
using APIProjectCamp.Dtos.MessageDtos;
using APIProjectCamp.Entities;
using AutoMapper;

namespace APIProjectCamp.Mapping
{
	public class GeneralMapping:Profile
	{
		public GeneralMapping() 
		{
			CreateMap<Feature,ResultFeatureDto>().ReverseMap();
			CreateMap<Feature,CreateFeatureDto>().ReverseMap();
			CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
			CreateMap<Feature,GetByIdFeatureDto>().ReverseMap();


			CreateMap<Message,ResultMessageDto>().ReverseMap();
			CreateMap<Message, CreateMessageDto>().ReverseMap();
			CreateMap<Message, UpdateMessageDto>().ReverseMap();
			CreateMap<Message, GetByIdMessageDto>().ReverseMap();
		}
	}
}
