namespace Refactoring.Models.FactorFile
{
    public class AdminAccount : IAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public AdminAccount(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
        }

    }
}
