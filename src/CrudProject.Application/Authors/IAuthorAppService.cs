using Abp.Application.Services;
using CrudProject.Authors.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.Authors
{
	public interface IAuthorAppService : IApplicationService
	{
		public IEnumerable<AuthorDto> GetAll();
		public Task<AuthorDto> GetById(int id);
		public Task<AuthorDto> Create(AuthorDto model);
		public Task<AuthorDto> Update(AuthorDto model);
		public void Delete(int id);

	}
}
