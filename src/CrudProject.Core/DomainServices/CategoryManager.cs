using Abp.Domain.Repositories;
using Abp.Domain.Services;
using CrudProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.DomainServices
{
	public class CategoryManager : DomainService, ICategoryManager
	{
		private readonly IRepository<Category> _categoryRepository;
		public CategoryManager(IRepository<Category> categoryRepository)
		{
			_categoryRepository = categoryRepository;

		}
		public async Task<Category> Create(Category model)
		{
			return await _categoryRepository.InsertAsync(model);
		}

		public async void Delete(int id)
		{
			var category = _categoryRepository.FirstOrDefault(x => x.Id == id);
			if (category == null)
			{
				throw new Exception("category Not Found");
			}
			else
			{
				await _categoryRepository.DeleteAsync(id);
			}
		}

		public IEnumerable<Category> GetAll()
		{
			return _categoryRepository.GetAll();
		}

		public async Task<Category> GetById(int id)
		{
			return await _categoryRepository.GetAsync(id);
		}

		public async Task<Category> Update(Category model)
		{
			var category = _categoryRepository.FirstOrDefault(x => x.Id == model.Id);
			if (category == null)
			{
				throw new Exception("category Not Found");
			}
			else
			{
				return await _categoryRepository.UpdateAsync(model);
			}
		}
	}
}
