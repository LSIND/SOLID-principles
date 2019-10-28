using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamplesApp.DIP
{
    public class Email
    {
        public void Send()
        {
            // отправка email
        }
    }

    public class BadNotification // генерация уведомления на email
    {
        private Email email;
        public BadNotification()
        {
            email = new Email();
        }

        public void EmailDistribution()
        {
            email.Send();
        }
    }
}
