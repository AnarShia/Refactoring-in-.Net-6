using System.ComponentModel.DataAnnotations;

namespace Refactoring.Models.FactorFile
{
    public class CompanyAccount : IAccount
    {
        [Key] public int Id { get; set; }

        [Required] public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required][InvalidCompanyName] public string CompanyName { get; set; }

        public CompanyAccount(int id, string name, string email, string password, string companyName)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            CompanyName = companyName;
        }
    }
}