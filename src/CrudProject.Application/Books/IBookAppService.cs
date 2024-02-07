using Abp.Application.Services;
using CrudProject.Authors.Dto;
using CrudProject.Books.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.Books
{
	public interface IBookAppService : IApplicationService
	{
		public IEnumerable<BookDto> GetAll();
		public Task<BookDto> GetById(int id);
		public Task<BookDto> Create(BookDto model);
		public Task<BookDto> Update(BookDto model);
		public void Delete(int id);
	}
}
