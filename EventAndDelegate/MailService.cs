using System;
using System.Threading;

namespace EventAndDelegate
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending Mail: " + e.Video.Title + " is encoded");
            Thread.Sleep(3000);
        }
    }
}
