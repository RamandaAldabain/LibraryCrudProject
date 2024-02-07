using Abp.Domain.Services;
using CrudProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.DomainServices
{
	public interface ICategoryManager : IDomainService
	{
		IEnumerable<Category> GetAll();
		Task<Category> GetById(int id);
		Task<Category> Create(Category model);
		Task<Category> Update(Category model);
		void Delete(int id);
	}
}
