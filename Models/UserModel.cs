using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorToDoApp.Models
{
	public class UserModel
	{
		public string UserId { get; set; }

		public string UserName { get; set; } = string.Empty;

		public string Password { get; set; } = string.Empty;
	}
}
