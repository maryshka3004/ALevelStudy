using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLogger
{
    internal class Notifications
    {
        private readonly Actions _actions;

        public Notifications(Actions actions)
        {
            _actions = actions;
        }

        public void Notify(NotifyType type, string message, string to)
        {
            _actions.Logging(Result.Info, $"Notification was for type {type}");
        }
    }
}
}
