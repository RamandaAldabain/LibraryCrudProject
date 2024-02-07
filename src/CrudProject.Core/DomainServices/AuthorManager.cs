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
	public  class AuthorManager : DomainService, IAuthorManager
	{
		private readonly IRepository<Author> _authorRepository;
        public AuthorManager(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public async Task<Author> Create(Author model)
		{
			return await _authorRepository.InsertAsync(model);
		}

		public async void Delete(int id)
		{
			var author = _authorRepository.FirstOrDefault(x => x.Id == id);
			if (author == null)
			{
				throw new Exception("author Not Found");
			}
			else
			{
				await _authorRepository.DeleteAsync(id);
			}
		}

		public  IEnumerable<Author> GetAll()
		{
			return _authorRepository.GetAll();
		}

		public async Task<Author> GetById(int id)
		{
			return await _authorRepository.GetAsync(id);
		}

		public async Task<Author> Update(Author model)
		{
			var author = _authorRepository.FirstOrDefault(x => x.Id == model.Id);
			if (author == null)
			{
				throw new Exception("author Not Found");
			}
			else
			{
				return await _authorRepository.UpdateAsync(model);
			}
		}
	}
}
