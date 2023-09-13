using _01_Exercise.Interfaces;
using _01_Exercise.Models;
using System.Linq.Expressions;

namespace _01_Exercise.Services;

internal class UserService : IUserService
{
    private List<User> _users = new List<User>();


    public void CreateUser(UserCreateRequest req)
    {
        _users.Add(new User
        {
            Id = Guid.NewGuid(),
            FirstName = req.FirstName,
            LastName = req.LastName,
            Email = req.Email,
        });

        //handle password separetely for security reasons
    }

    //public User GetUser(Expression<Func<User, bool>> expression)
    //{
    //    throw new NotImplementedException();

    //}

    public User GetUser(Func<User, bool> expression)
    {
        var user = _users.FirstOrDefault(expression, null!);
        return user;
    }

    public IEnumerable<User> GetUsers()
    {
        return _users;
    }
}
