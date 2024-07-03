using System.Collections.Generic;
using System.Linq;
using prototype3.Core.Models;

namespace prototype3.Core.Data;

public class UserRepository
{
    private readonly List<User> _users = new List<User>
    {
        new User { Id = 1, Name = "admin", Password = "admin123", Role = "Admin" },
        new User { Id = 2, Name = "user", Password = "user123", Role = "User" }
    };

    public IEnumerable<User> GetAllUsers()
    {
        return _users;
    }

    public User GetUser(string username, string password)
    {
        return _users.FirstOrDefault(u => u.Name == username && u.Password == password);
    }
}