using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class MediaPlayerAdapter : IMediaPlayer
    {
        private readonly VideoPlayer _videoPlayer;

        public MediaPlayerAdapter(string filetype)
        {
            if (filetype.ToLower() == "mkv" ||
                filetype.ToLower() == "avi")
                _videoPlayer = new VideoPlayer();
        }
        public void Play(string fileType, string fileName)
        {
            if (fileType.ToLower() == "avi")
                _videoPlayer.PlayAVI(fileName);
            else if (fileType.ToLower() == "mkv")
                _videoPlayer.PlayMKV(fileName);
        }
    }
}
