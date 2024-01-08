using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DAL.Interfaces;

namespace Demo.DAL.Data
{
    public class UtilisateurData : IUtilisateurData
	{
		public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public string Nom { get; set; }

		public string Prenom { get; set; }
		public string Email { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public DateTime DateNaissance { get; set; }
	}
}
