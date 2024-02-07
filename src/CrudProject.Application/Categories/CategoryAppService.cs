using Abp.Application.Services;
using AutoMapper;
using CrudProject.Categories.Dto;
using CrudProject.DomainServices;
using CrudProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.Categories
{
	public class CategoryAppService : ApplicationService, ICategoryAppService
	{
		private readonly ICategoryManager _categoryManager;
		private readonly IMapper _mapper;

        public CategoryAppService(ICategoryManager categoryManager , IMapper mapper)
        {
			_categoryManager = categoryManager;
			_mapper = mapper;
			
        }
        public async Task<CategoryDto> Create(CategoryDto model)
		{
			var category = _mapper.Map<CategoryDto, Category>(model);
			category = await _categoryManager.Create(category);
			return _mapper.Map<Category, CategoryDto>(category);
		}

		public async void Delete(int id)
		{
			_categoryManager.Delete(id);
		}

		public IEnumerable<CategoryDto> GetAll()
		{
			var categorys = _categoryManager.GetAll().ToList();
			return _mapper.Map<List<Category>, List<CategoryDto>>(categorys);
		}

		public async Task<CategoryDto> GetById(int id)
		{
			var category = await _categoryManager.GetById(id);
			return _mapper.Map<Category, CategoryDto>(category);
		}

		public async Task<CategoryDto> Update(CategoryDto model)
		{
			var category = _mapper.Map<CategoryDto, Category>(model);
			var UpdatedCategory = await _categoryManager.Update(category);
			return _mapper.Map<Category, CategoryDto>(UpdatedCategory);
		}
	}
}
