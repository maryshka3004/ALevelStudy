using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal class Run
    {
        private readonly Users _users;

        public Run(Users users)
        {
            _users = users;
        }

        public void Start()
        {
            var firstName = "first name";
            var lastName = "last name";

            var userId = _users.AddUser(firstName, lastName);

            _users.GetUser(userId);
        }
    }
}