namespace Demo.BLL.Interfaces
{
    public interface IUtilisateurModel
    {
        DateTime DateNaissance { get; set; }
        string Email { get; set; }
        int Id { get; set; }
        string Nom { get; set; }
        string Prenom { get; set; }
    }
}