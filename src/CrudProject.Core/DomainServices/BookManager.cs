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
	public class BookManager : DomainService, IBookManager
	{
		private readonly IRepository<Book> _bookRepository;
		public BookManager(IRepository<Book> bookRepository)
		{
			_bookRepository = bookRepository;
		}
		public async Task<Book> Create(Book model)
		{
			return await _bookRepository.InsertAsync(model);
		}

		public async void Delete(int id)
		{
			var book = _bookRepository.FirstOrDefault(x => x.Id == id);
			if (book == null)
			{
				throw new Exception("book Not Found");
			}
			else
			{
				await _bookRepository.DeleteAsync(id);
			}
		}

		public IEnumerable<Book> GetAll()
		{
			return _bookRepository.GetAll();
		}

		public async Task<Book> GetById(int id)
		{
			return await _bookRepository.GetAsync(id);

		}

		public async Task<Book> Update(Book model)
		{
			var book = _bookRepository.FirstOrDefault(x => x.Id == model.Id);
			if (book == null)
			{
				throw new Exception("book Not Found");
			}
			else
			{
				return await _bookRepository.UpdateAsync(model);
			}
		}
	}
}
