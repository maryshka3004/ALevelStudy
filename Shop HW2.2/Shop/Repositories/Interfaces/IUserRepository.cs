using Shop.Entities;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repositories.Interfaces
{
    internal interface IUserRepository
    {
        string AddUser(User user);
        UserEntity GetUser(string id);
    }
}
