using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Adapter
{
    internal class VideoPlayer
    {
        public void PlayAVI(string filename) =>
            Console.Write($"начато воспроизведение AVI файл {filename} с с кодеком AVI37583 ");

        public void PlayMKV(string filename) =>
           Console.Write($"начато воспроизведение MKV файл {filename} с с кодеком mkv_8ewf ");
    }
}
