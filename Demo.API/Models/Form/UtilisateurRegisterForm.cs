using Demo.API.Interfaces;
using Demo.BLL.Interfaces;
using Demo.BLL.Models;
using System.ComponentModel.DataAnnotations;

namespace Demo.API.Models.Form
{
    public class UtilisateurRegisterForm : IUtilisateurRegisterForm
	{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

		[Required]
		[MaxLength(80)]
		[MinLength(2)]
		public string Nom { get; set; }
		[Required] 
		[MaxLength(80)]
		[MinLength(2)]
		public string Prenom { get; set; }
		[Required]
		[EmailAddress]
		[MaxLength(100)]
		public string Email { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

		[Required]
		public DateTime DateNaissance { get; set; }

		 
	}
}
