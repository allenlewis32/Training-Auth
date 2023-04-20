﻿using System.ComponentModel.DataAnnotations;

namespace Auth.Models
{
	public class StudentModel
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Email { get; set; }
	}
}
