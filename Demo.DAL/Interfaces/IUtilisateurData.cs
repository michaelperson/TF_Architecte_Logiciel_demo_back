namespace Demo.DAL.Interfaces
{
    public interface IUtilisateurData
    {
        DateTime DateNaissance { get; set; }
        string Email { get; set; }
        int Id { get; set; }
        string Nom { get; set; }
        string Prenom { get; set; }
    }
}