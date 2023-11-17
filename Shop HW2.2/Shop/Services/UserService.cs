using Shop.Models;
using Shop.Repositories;
using Shop.Repositories.Interfaces;
using Shop.Services.Interfaces;

namespace Shop.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public string AddUser(string firstName, string lastName)
        {
            var user = new User()
            {
                Name = $"{firstName} {lastName}",
                Email = "someEmail@gmail.com"
            };

            _userRepository.AddUser(user);

            return userId;

        }

        public User GetUser(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
