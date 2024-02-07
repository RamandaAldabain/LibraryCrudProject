using Abp.Application.Services;
using AutoMapper;
using CrudProject.Authors.Dto;
using CrudProject.DomainServices;
using CrudProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.Authors
{
	public class AuthorAppService : ApplicationService, IAuthorAppService
	{
		private readonly IAuthorManager _authorManager;
		private readonly IMapper  _mapper;
		public AuthorAppService(IAuthorManager authorManager, IMapper  mapper)
		{
			_authorManager = authorManager;
			_mapper = mapper;
		}
		public async Task<AuthorDto> Create(AuthorDto model)
		{
			var author = _mapper.Map<AuthorDto, Author>(model);
			author = await _authorManager.Create(author);
			return _mapper.Map<Author, AuthorDto>(author);
		}

		public void Delete(int id)
		{
			_authorManager.Delete(id);
		}

		public IEnumerable<AuthorDto> GetAll()
		{
			var authors = _authorManager.GetAll().ToList();
			return _mapper.Map<List<Author>, List<AuthorDto>>(authors);
		}

		public async Task<AuthorDto> GetById(int id)
		{
			var author = await _authorManager.GetById(id);
			return _mapper.Map<Author, AuthorDto>(author);
		}

		public async Task<AuthorDto> Update(AuthorDto model)
		{
			var author = _mapper.Map<AuthorDto, Author>(model);
			var UpdatedAuthor = await _authorManager.Update(author);
			return _mapper.Map<Author, AuthorDto>(UpdatedAuthor);
		}
	}
}
