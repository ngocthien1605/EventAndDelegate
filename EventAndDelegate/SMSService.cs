using System;
using System.Threading;

namespace EventAndDelegate
{
    public class SMSService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending SMS: " + e.Video.Title + " is encoded");
            Thread.Sleep(3000);
        }
    }
}
