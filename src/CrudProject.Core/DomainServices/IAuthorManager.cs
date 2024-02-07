using Abp.Domain.Services;
using CrudProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.DomainServices
{
	public interface IAuthorManager : IDomainService
	{
		IEnumerable<Author> GetAll();
		Task<Author> GetById(int id);
		Task<Author> Create(Author model);
		Task<Author> Update(Author model);
		void Delete(int id);
	}
}
