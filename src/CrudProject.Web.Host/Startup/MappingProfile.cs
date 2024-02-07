using AutoMapper;
using CrudProject.Authors.Dto;
using CrudProject.Books.Dto;
using CrudProject.Categories.Dto;
using CrudProject.Models;

namespace CrudProject.Web.Host.Startup
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Author, AuthorDto>();
			CreateMap<AuthorDto, Author>();
			CreateMap<Book, BookDto>();
			CreateMap<BookDto, Book>();
			CreateMap<Category, CategoryDto>();
			CreateMap<CategoryDto, Category>();


		}
	}
}