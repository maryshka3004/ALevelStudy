using Shop.Models;
using Shop.Entities;

namespace Shop.Services.Interfaces
{
    internal interface IUserService
    {
        string AddUser(User user);
        User GetUser(string Id);
    }
}
