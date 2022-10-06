using System.Collections.Generic;

namespace Module33_
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();

        User GetUserByLogin(string login);
    }
}
