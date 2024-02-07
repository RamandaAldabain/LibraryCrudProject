using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.Models
{
	public class Author : FullAuditedEntity
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }

		public ICollection<Book> Books { get; set; }
	}
}
