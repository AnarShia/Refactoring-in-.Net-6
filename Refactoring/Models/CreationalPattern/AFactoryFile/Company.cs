namespace Refactoring.Models.FactorFile;

public class Company : ICompany
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}