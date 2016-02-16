using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo_13.Models
{
    public class Test1
    {
    }

    public interface IMessageingService
    {
        void SendMessage();
    }


    public class EmailService:IMessageingService
    {
        public void SendMessage()
        {
        }
    }

    public class NotificationSystem
    {
        //private EmailService svc;
        private IMessageingService svc;
        public NotificationSystem(IServiceLocator locator)
        {
            //  svc=new EmailService();
            svc = locator.GetMessagingService();
        }

        public void InterestingEventHappened()
        {
            svc.SendMessage();
        }
        /*
        NotificationSystem类依赖于EmailService类，当一个组件依赖于其他组件时，我们称其为耦合。

        把依赖的创建移到使用这些依赖的类的外部，这称为控制反转模式，之所以这样命名，是因为反转的是依赖的创建，正因为如此，才消除了消费者类对依赖创建的控制。
        */
    }

    /// <summary>
    /// 把服务定位器作为一个接口，而不是一个具体类型
    /// </summary>
    public interface IServiceLocator
    {
        IMessageingService GetMessagingService();
    }
}