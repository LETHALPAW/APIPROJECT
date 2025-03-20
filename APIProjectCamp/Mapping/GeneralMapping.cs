using AutoMapper;
using APIProjectCamp.Entities;
using APIProjectCamp.Dtos.FeatureDtos;
using APIProjectCamp.Dtos.MessageDtos;
using APIProjectCamp.Dtos.ProducDtos;

namespace APIProjectCamp.Mapping
{
	public class GeneralMapping:Profile
	{
		public GeneralMapping()
		{
			CreateMap<Feature, ResultFeatureDto>().ReverseMap();
			CreateMap<Feature, CreateFatureDto>().ReverseMap();
			CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
			CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

			CreateMap<Message, ResultMessageDto>().ReverseMap();
			CreateMap<Message, CreateMessageDto>().ReverseMap();
			CreateMap<Message, UpdateMessageDto>().ReverseMap();
			CreateMap<Message, GetByIdMessageDto>().ReverseMap();

			CreateMap<Product, CreateProductDto>().ReverseMap();
			CreateMap<Product, ResultProductWithCategoryDto>().ForMember(x => x.CategoryName, y => y.MapFrom(z => z.category.CategoryName)).ReverseMap();
		}
	}
}
