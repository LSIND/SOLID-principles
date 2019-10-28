using System;
using System.Collections.Generic;
using System.Text;

//with DI
namespace SolidExamplesApp.DIP
{
    public interface IMessenger
    {
        void Send();
    }

    public class GoodEmail : IMessenger
    {
        public void Send()
        {
            // отправка email
        }
    }

    public class GoodNotification // генерация уведомления на email
    {
        private IMessenger _messenger;
        public GoodNotification()
        {
            _messenger = new GoodEmail();
        }

        public void DoNotify()
        {
            _messenger.Send();
        }
    }

    //-----------------------------//

    public class DI_Notification
    {
        private IMessenger _messenger;
        public DI_Notification(IMessenger mes)
        {
            _messenger = mes;
        }

        public void DoNotify()
        {
            _messenger.Send();
        }
    }
}
