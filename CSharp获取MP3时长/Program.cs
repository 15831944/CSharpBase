using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp获取MP3时长
{
    class Program
    {
        static void Main(string[] args)
        {
            Mp3FileReader _reader = new Mp3FileReader(@"C:\Users\Ezong\Desktop\简弘亦 - 出卖.mp3");
            var duration = _reader.TotalTime.Seconds+ _reader.TotalTime.Minutes*60;
            Console.WriteLine(duration);
        }
    }
}
