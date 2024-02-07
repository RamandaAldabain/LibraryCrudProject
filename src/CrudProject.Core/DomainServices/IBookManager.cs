using Abp.Domain.Services;
using CrudProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.DomainServices
{
	public interface IBookManager : IDomainService
	{
		IEnumerable<Book> GetAll();
		Task<Book> GetById(int id);
		Task<Book> Create(Book model);
		Task<Book> Update(Book model);
		void Delete(int id);
	}
}
