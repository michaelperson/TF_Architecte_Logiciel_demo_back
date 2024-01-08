using Demo.API.Interfaces;
using Demo.API.Models.Form;
using Demo.BLL.Interfaces;
using Demo.BLL.Models;

namespace Demo.API.Mapper
{
    public static class Mapper
    {
        internal static IUtilisateurModel ApiToBll(this IUtilisateurRegisterForm form)
        {
            return new UtilisateurModel()
            {
                Nom = form.Nom,
                Prenom = form.Prenom,
                Email = form.Email,
                DateNaissance = form.DateNaissance
            };
        }
    }
}
