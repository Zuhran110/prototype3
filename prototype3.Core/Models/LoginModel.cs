using prototype3.Core.Data;
using System.Collections.Generic;

namespace prototype3.Core.Models;

public class LoginModel
{
    private readonly UserRepository _userRepository;

    public LoginModel()
    {
        _userRepository = new UserRepository();
    }

    public User VerifyUser(string username, string password)
    {
        return _userRepository.GetUser(username, password);
    }
}