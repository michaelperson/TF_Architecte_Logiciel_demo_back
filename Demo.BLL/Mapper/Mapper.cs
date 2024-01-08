using Demo.BLL.Interfaces;
using Demo.BLL.Models;
using Demo.DAL.Data;
using Demo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Mapper
{
    public static class Mapper
    {
        // BllToDal
        internal static IUtilisateurData BllToDal(this IUtilisateurModel model)
        {
            return new UtilisateurData()
            {
                Id = model.Id,
                Nom = model.Nom,
                Prenom = model.Prenom,
                Email = model.Email,
                DateNaissance = model.DateNaissance
            };
        }

        // DalToBll
        internal static IUtilisateurModel DalToBll(this IUtilisateurData data)
        {
            return new UtilisateurModel()
            {
                Id = data.Id,
                Nom = data.Nom,
                Prenom = data.Prenom,
                Email = data.Email,
                DateNaissance = data.DateNaissance
            };
        }
    }
}
