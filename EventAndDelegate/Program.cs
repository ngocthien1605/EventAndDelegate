using Microsoft.Azure.ServiceBus;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAndDelegate
{

    class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher

            var mailService = new MailService(); //Mail subscriber
            var smsService = new SMSService(); // SMS subscriber 

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;
            videoEncoder.Encode(video);
               


        }
    
        
       
    }
}
