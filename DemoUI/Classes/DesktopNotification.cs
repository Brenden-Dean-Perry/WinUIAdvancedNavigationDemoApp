using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases;

namespace Osmium.Classes
{
    internal class DesktopNotification : INotify
    {
        public DesktopNotification()
        {
            
        }

        public DateTime GetInputBoxDate()
        {
            throw new NotImplementedException();
        }

        public string GetInputBoxValue()
        {
            throw new NotImplementedException();
        }

        public NotificationResponse Inputbox(string Message, int MaxAllowedCharaters = 100)
        {
            throw new NotImplementedException();
        }

        public NotificationResponse InputboxDateTime(string Message, DateTime DefaultDateTime)
        {
            throw new NotImplementedException();
        }

        public NotificationResponse Notify(string Message)
        {
            throw new NotImplementedException();
        }

        public NotificationResponse NotifyError(string Message)
        {
            throw new NotImplementedException();
        }

        public NotificationResponse NotifyErrorYesNo(string Message)
        {
            throw new NotImplementedException();
        }

        public NotificationResponse NotifyWarning(string Message)
        {
            throw new NotImplementedException();
        }

        public NotificationResponse NotifyWarningYesNo(string Message)
        {
            throw new NotImplementedException();
        }

        public NotificationResponse NotifyYesNo(string Message)
        {
            throw new NotImplementedException();
        }
    }
}
