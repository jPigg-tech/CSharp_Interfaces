using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encodeing logic 
            //...
            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }

        // In this class its not talking about SMS, Emails we're 
        // talking about abstarctions (INotificationChannel)
        // With this we achieve Open Close Principal, our software is 
        // open to extensions, we create new implementations of INotifacationChannel
        // and closed for modification
    }
}
