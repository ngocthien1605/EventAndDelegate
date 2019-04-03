using System;
using System.Threading;

namespace EventAndDelegate
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        /*
         * Way 1
        // 1. Define a delegate VideoEncodedEventHandler
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // 2. Define an event <VideoEncoded> based on above delegate <VideoEncodedEventHandler>
        public event VideoEncodedEventHandler VideoEncoded;
        */

        /*
         * Way 2
         * combination of (1.) and (2.)
         * There are 2 types of .NET delegate class for event: EventHandler and generic EventHandler<>
        public event EventHandler VideoEncoding;
        */
        //pass additional data (VideoEventArgs) to event using generic EventHandler<>
        public event EventHandler<VideoEventArgs> VideoEncoded; // equivalent (1.) and (2.)

        

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            
            OnVideoEncoded(video);
        }

        
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                // 3. Raise the event: VideoEncoded to other subscriber(s)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
