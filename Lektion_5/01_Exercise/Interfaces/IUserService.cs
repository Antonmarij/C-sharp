using _01_Exercise.Models;
using System.Linq.Expressions;

namespace _01_Exercise.Interfaces;

internal interface IUserService
{
    public void CreateUser(UserCreateRequest req);
    public User GetUser(Func<User, bool> expression);

    //public User GetUser(Expression<Func<User, bool>> expression);

    public IEnumerable<User> GetUsers();

}
