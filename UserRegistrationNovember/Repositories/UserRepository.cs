using UserRegistrationNovember.Controllers;
using UserRegistrationNovember.Models;

namespace UserRegistrationNovember.Repositories;

public class UserRepository
{
    public List<User> users = new List<User>();
    
    public void Save(User user)
    {
        user.Id = Guid.NewGuid();
        users.Add(user);
    }

    public List<User> GetAll()
    {
        return users;
    }
}