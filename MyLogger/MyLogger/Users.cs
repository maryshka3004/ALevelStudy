using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal class Users
    {
        private readonly UserRepository _userRepository;
        private readonly UserRepository _actions;
        private readonly UserRepository _notifications;

        public Users(
            UserRepository userRepository,
            Actions actions,
            Notifications notifications)
        {
            _userRepository = userRepository;
            _actions = actions;
            _notifications = notifications;
        }

        public string AddUser(string firstName, string lastName)
        {
            var id = _userRepository.AddUser(firstName, lastName);
            _actions.Logging(Result.Info, $"Created user with Id = {id}");
            var notifyMessage = "registration successfull";
            var notifyTo = "user@gmail.com";
            _notifications.Notify(NotifyType.Email.notifyMessage, notifyTo);
            return id;
        }

        public PersonalInformation GetUser(string id)
        {
            var user = _userRepository.GetUser(id);

            if (user == null)
            {
                _actions.Logging(Result.Warning, $"Not founded user id = {id}");
                return null;
            }

            return new PersonalInformation()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                FullName = $"{user.FirstName} {user.LastName}"
            };
        }
    }
}
