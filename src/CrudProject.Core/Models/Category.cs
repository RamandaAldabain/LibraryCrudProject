using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.Models
{
	public class Category : FullAuditedEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }

		ICollection<Book> Books { get; set; }
	}
}
