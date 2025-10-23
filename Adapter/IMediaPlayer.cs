using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal interface IMediaPlayer
    {
        void Play(string fileType, string fileName);
    }
}
