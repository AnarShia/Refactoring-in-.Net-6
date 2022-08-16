namespace Refactoring.Models.FactorFile
{
    public abstract class UserFactory
    {

        public abstract IAccount CreateUser(int id, string name, string email, string password);
        public abstract ICompany CreateCompany(int id, string name, string email, string password);
    }
}
