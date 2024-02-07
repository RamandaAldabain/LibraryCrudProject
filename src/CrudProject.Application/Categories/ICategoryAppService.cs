using Abp.Application.Services;
using CrudProject.Authors.Dto;
using CrudProject.Categories.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.Categories
{
	public interface ICategoryAppService : IApplicationService
	{
		public IEnumerable<CategoryDto> GetAll();
		public Task<CategoryDto> GetById(int id);
		public Task<CategoryDto> Create(CategoryDto model);
		public Task<CategoryDto> Update(CategoryDto model);
		public void Delete(int id);
	}
}
