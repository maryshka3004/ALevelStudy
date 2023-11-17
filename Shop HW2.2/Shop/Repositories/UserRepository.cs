using Shop.Entities;
using Shop.Models;
using Shop.Repositories.Interfaces;
using System.Runtime.CompilerServices;

namespace Shop.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly List<UserEntity> userEntities = new List<UserEntity>();
        public string AddUser(User user)
        {
            var userEntity = new UserEntity()
            {
                Id = Guid.NewGuid(),
                Name = user.Name,
                Email = user.Email,
            };

            userEntities.Add(userEntity);

            return userEntity.Id.ToString();
        }

        public UserEntity GetUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}