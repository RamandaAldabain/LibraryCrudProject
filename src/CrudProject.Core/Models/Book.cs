using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.Models
{
	public class Book : FullAuditedEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }

		// Relations
		public int AuthorId { get; set; }
		public Author Author { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
