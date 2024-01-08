using Demo.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Interfaces
{
    //Le repository
    public interface IUtilisateurRepository
    {

		IUtilisateurData Get(int id);
		IEnumerable<IUtilisateurData> GetAll(int id);
		void Insert(IUtilisateurData data);
		void Update(IUtilisateurData data);
		void Delete(int id);
	}
}
