﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProject.Books.Dto
{
	public class BookDto
	{
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string Description { get; set; }
	}
}
