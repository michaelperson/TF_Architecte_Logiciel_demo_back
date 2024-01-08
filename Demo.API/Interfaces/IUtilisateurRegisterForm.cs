using Demo.BLL.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Demo.API.Interfaces
{
    public interface IUtilisateurRegisterForm
    {
        [Required]
        DateTime DateNaissance { get; set; }
        [Required] 
        [EmailAddress]
        [MaxLength(100)]
        string Email { get; set; }
		[Required]
		[MaxLength(80)]
        [MinLength(2)]
		string Nom { get; set; }
		[Required]
		[MaxLength(80)]
		[MinLength(2)]
		string Prenom { get; set; }
         
    }
}