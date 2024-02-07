using Abp.Application.Services;
using AutoMapper;
using CrudProject.Books.Dto;
using CrudProject.DomainServices;
using CrudProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.Books
{
	public class BookAppService : ApplicationService, IBookAppService
	{
		private readonly IBookManager _bookManager;
		private readonly IMapper _mapper;
        public BookAppService(IBookManager bookManager , IMapper mapper)
        {
			_bookManager = bookManager;
			_mapper = mapper;
            
        }
        public async Task<BookDto> Create(BookDto model)
		{
			var book = _mapper.Map<BookDto, Book>(model);
			book = await _bookManager.Create(book);
			return _mapper.Map<Book, BookDto>(book);
		}

		public void Delete(int id)
		{
			_bookManager.Delete(id);
		}

		public IEnumerable<BookDto> GetAll()
		{
			var books = _bookManager.GetAll().ToList();
			return _mapper.Map<List<Book>, List<BookDto>>(books);
		}

		public async Task<BookDto> GetById(int id)
		{
			var book = await _bookManager.GetById(id);
			return _mapper.Map<Book, BookDto>(book);
		}

		public async Task<BookDto> Update(BookDto model)
		{
			var book = _mapper.Map<BookDto, Book>(model);
			var UpdatedBook = await _bookManager.Update(book);
			return _mapper.Map<Book, BookDto>(UpdatedBook);
		}
	}
}
