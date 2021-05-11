using LibVLCSharp.Shared;
using System;
using System.Threading.Tasks;

namespace MovieFrameArt
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Core.Initialize();
            using (var libvlc = new LibVLC())
            {
                var uri = new Uri(@"\\MEDIASERVER\Movies\Star Wars (1977)\Star.Wars.1977.Remux-2160p.HDR.HEVC.TrueHD.Atmos.7.1.mkv");
                var video = new Media(libvlc, uri);
                await video.Parse();
            }
        }
    }
}
