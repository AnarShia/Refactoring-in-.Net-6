namespace Refactoring.Models.FactorFile;

public interface IAccount
{
    int Id { get; set; }
    string Name { get; set; }
    string Email { get; set; }
    string Password { get; set; }
}