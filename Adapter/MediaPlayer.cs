using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class MediaPlayer : IMediaPlayer
    {
        private readonly IMediaPlayer _adapter;

        public MediaPlayer(IMediaPlayer adapter)
        {
            _adapter = adapter;
        }

        public void Play(string fileType, string fileName)
        {
            var type = fileType.ToLower();

            switch(type)
            {
                case "mkv":
                case "avi":
                    _adapter.Play(type, fileName);
                    break;
                case "mp3":
                    Console.WriteLine($"начато воспроизведение mp3 файл {fileName} с с кодеком ???? ");
                    break;
                case "ac3":
                    Console.WriteLine($"начато воспроизведение ac3 файл {fileName} с с кодеком ca3if ");
                    break;
                default:
                    Console.WriteLine("невозможно воспроизвести данный формат");
                    break;
            }
        }
    }
}
